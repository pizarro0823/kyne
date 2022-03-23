using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kine.ingresos
{
    public partial class Ingresos : Form
    {
        Clases.CrearGrowl growl = new Clases.CrearGrowl();
        ingresos.DAOingresos daoing = new DAOingresos();
        #region atributos resize y move
        public int xClick = 0, yClick = 0;
        bool inSizeDrag = false;
        #endregion final atributos resize y move

        public Ingresos()
        {
            InitializeComponent();
            caldesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            DateTime dti = DateTime.Now.AddMonths(1);
            calhasta.Value = dti.AddDays(-dti.Day);
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            consultarInfo(true);
        }

        public void consultarInfo(Boolean estado)
        {
            if (caldesde.Value.Date <= calhasta.Value.Date)
            {
                DataTable dting = daoing.consultarRegistro(caldesde.Value.Date, calhasta.Value.Date, estado);
                llenarGrid(adgvingresos, dting);
                for (int i = 0; i < adgvingresos.Columns.Count; i++)
                {
                    adgvingresos.Columns[i].ReadOnly = true;
                }
                if (estado)
                {
                    adgvingresos.RowsDefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    adgvingresos.RowsDefaultCellStyle.BackColor = Color.FromArgb(254, 238, 144);
                }
                llenarTotales();
            }
            else
            {
                growl.crearGrowl("Las fechas ingresadas son erroneas", 2, this);
            }
        }

        public void llenarTotales()
        {
            double valor = adgvingresos.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells["valor"].Value != DBNull.Value & x.Cells["valor"].Value != null ? Convert.ToDouble(x.Cells["valor"].Value) : 0);
            lbltotales.Visible = true;
            lbltotales.Text = "Total ingresos: "+valor.ToString("0,0.##", CultureInfo.InvariantCulture); ;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adgvingresos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            if (this.adgvingresos.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(
                        this.adgvingresos.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void copiarConEncabezdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adgvingresos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            if (this.adgvingresos.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(
                        this.adgvingresos.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void datosEliminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datosEliminadosToolStripMenuItem.Text.Equals("Datos eliminados"))
            {
                datosEliminadosToolStripMenuItem.Text = "Datos normales";
                consultarInfo(false);
            }
            else
            {
                datosEliminadosToolStripMenuItem.Text = "Datos eliminados";
                consultarInfo(true);
            }
        }


        #region metodos generales
        int statewindow = 0;
        Control sizeform = new Control();
        private void btnmax_Click(object sender, EventArgs e)
        {
            if (statewindow == 0)
            {
                sizeform.Size = this.Size;
                this.Size = SystemInformation.WorkingArea.Size;
                this.CenterToScreen();
                statewindow = 1;
            }
            else
            {
                if (statewindow == 1)
                {
                    this.Size = sizeform.Size;
                    this.CenterToScreen();
                    statewindow = 0;
                }
            }
        }
        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void gunaButton5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void metodosMouseyPaint()
        {
            pbresize.MouseUp += delegate
            {
                inSizeDrag = false;
            };
            pbresize.MouseDown += (o, ea) =>
            {
                inSizeDrag = true;
            };
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            metodosMouseyPaint();
        }


        private void gen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left & inSizeDrag == false)
            {
                xClick = e.X;
                yClick = e.Y;
            }
            else
            {
                if (inSizeDrag == false)
                {
                    this.Left = this.Left + (e.X - xClick);
                    this.Top = this.Top + (e.Y - yClick);
                }
            }
            if (inSizeDrag)
            {
                this.Width = ((this.Width - pbresize.Width) + e.Location.X);
                this.Height = ((this.Height - pbresize.Height) + e.Location.Y);
                this.Invalidate();
            }
        }
        #endregion metodos generales

        #region llenar advancedatagridview agregando filtros, limpiando filtros, eventos generales de filtros 

        /*
        metodo que recibe un advanceDatagridview y un datatable para llenar un determinado binding source con el datatable para luego llenar
        el gridview mensinado, determinando que bindingSource llenará
        */
        public void llenarGrid(ADGV.AdvancedDataGridView gv, DataTable dtinf)
        {
            BindingSource bs = determinarBinding(gv);
            limpiarAsignarFiltroySort(gv, bs, 1, true);
            limpiarAsignarFiltroySort(gv, bs, 2, true);
            bs.DataSource = dtinf;
            gv.DataSource = bs;
        }
        /*
        metodo que determina segun sea el advancedatagridview enviado como parametro que bindingsource utilizará, esto se detemrina con el nombre del gridview
        esto en caso de haber varios gridviews y bindingsouce
        ¡IMPORTANTE!: en caso de haber varios gridviews y bindingsouce recordar agregarlos a este metodo en el condicional, sino esto no funcionará correctamente
        */
        public BindingSource determinarBinding(ADGV.AdvancedDataGridView g)
        {
            BindingSource bs = new BindingSource();
            if (g.Name == "adgvingresos")
            {
                bs = bsgrid;
            }
            else if (g.Name == "cualquier otro gridview")
            {
                bs = null; // cualquier otro binding source
            }
            return bs;
        }
        /*
        metodo filter general para todo advancedatagrdview, determinando que bindingsource usará y limpiando el gridview y el binding source en caso de que tengan datos 
        filtrados
        ¡IMPORTANTE!: aqui se debe agregar metodo para que en caso de haber totales se recalculen cada vez que se filtre, si es requerido
        */
        private void dgv_filters(object sender, EventArgs e)
        {
            BindingSource bs = determinarBinding((ADGV.AdvancedDataGridView)sender);
            ADGV.AdvancedDataGridView g = (ADGV.AdvancedDataGridView)sender;
            limpiarAsignarFiltroySort(g, bs, 1, false);
            llenarTotales();
        }
        /*
        metodo sort general para todo advancedatagrdview, determinando que bindingsource usará y limpiando el gridview y el binding source en caso de que tengan datos 
        reorganizados
        */
        private void dgv_sort(object sender, EventArgs e)
        {
            BindingSource bs = determinarBinding((ADGV.AdvancedDataGridView)sender);
            limpiarAsignarFiltroySort((ADGV.AdvancedDataGridView)sender, bs, 2, false);
        }
        /*
        metodo que limpica tanto filtros como sort en caso de que la tabla ya tenga alguno de estos usados, para que cuando el usuario vuelva a buscar informacion
        los datos aparezcan de forma correcta y no filtrados o reorganizados
        */
        public void limpiarAsignarFiltroySort(ADGV.AdvancedDataGridView g, BindingSource bs, int t, bool clear)
        {
            if (t == 1)
            {
                if (clear == true)
                {
                    g.ClearFilter();
                    bs.Filter = null;
                }
                bs.Filter = g.FilterString;
            }
            else if (t == 2)
            {
                if (clear == true)
                {
                    g.ClearSort();
                    bs.Sort = null;
                }
                bs.Sort = g.SortString;
            }
        }

        #endregion llenar advancedatagridview agregando filtros, limpiando filtros, eventos generales de filtros 
    }
}
