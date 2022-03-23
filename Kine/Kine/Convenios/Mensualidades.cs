using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kine.Convenios
{
    public partial class Mensualidades : Form
    {
        #region atributos resize y move
        public int xClick = 0, yClick = 0;
        bool inSizeDrag = false;
        #endregion final atributos resize y move

        Clases.CrearGrowl growl = new Clases.CrearGrowl();
        DAOconvenio daoconv = new DAOconvenio();
        DataTable dtconv = new DataTable();
        public Mensualidades()
        {
            InitializeComponent();

            caldesde.Value = DateTime.Now.AddDays(-(DateTime.Now.Day - 1));
            DateTime dti = DateTime.Now.AddMonths(1);
            calhasta.Value = dti.AddDays(-dti.Day);
            chfecing.Checked = true;
            chfecfin.Checked = false;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            datosEliminadosToolStripMenuItem.Text = "Datos eliminados";
            consultarInfo(true);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar estos registros?", "Eliminar convenio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int c = 0;
                List<DataGridViewRow> rs = adgvconvenios.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells[0].Value) == true).ToList();
                foreach (DataGridViewRow r in rs)
                {
                    c = daoconv.eliminarConvenio(r.Cells["id_convenio"].Value);
                    if (c == 0)
                    {
                        break;
                    }
                }
                if (c != 0)
                {
                    consultarInfo(true);
                    growl.crearGrowl("Datos eliminados correctamente", 1, this);
                }
                else
                {
                    growl.crearGrowl("Error al eliminar los datos", 3, this);
                }
            }
        }

        public void consultarInfo(Boolean estado)
        {
            if (caldesde.Value.Date <= calhasta.Value.Date)
            {
                string col = "";
                if (chfecing.Checked)
                {
                    col = "fecha_inicio";
                }
                else
                {
                    col = "fecha_fin";
                }
                adgvconvenios.Columns.Clear();
                dtconv = daoconv.consultarConvenios(caldesde.Value.Date, calhasta.Value.Date, estado, col);
                llenarGrid(adgvconvenios, dtconv);
                adgvconvenios.Columns["id_convenio"].Visible = false;
                for (int i = 0; i < adgvconvenios.Columns.Count; i++)
                {
                    adgvconvenios.Columns[i].ReadOnly = true;
                }
                DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();
                ch.Name = "ch";
                ch.Width = 20;
                if (estado)
                {
                    adgvconvenios.Columns.Insert(0, ch);
                    adgvconvenios.RowsDefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    adgvconvenios.RowsDefaultCellStyle.BackColor = Color.FromArgb(254, 238, 144);
                }
            }
            else
            {
                growl.crearGrowl("Las fechas ingresadas son erroneas", 2, this);
            }
        }

        private void chfecing_Click(object sender, EventArgs e)
        {
            if (chfecing.Checked)
            {
                chfecfin.Checked = false;
            }
            else
            {
                chfecing.Checked = true;
            }
        }

        private void chfecfin_Click(object sender, EventArgs e)
        {
            if (chfecfin.Checked)
            {
                chfecing.Checked = false;
            }
            else
            {
                chfecfin.Checked = true;
            }
        }


        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adgvconvenios.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            if (this.adgvconvenios.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(
                        this.adgvconvenios.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void copiarConEncabezdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adgvconvenios.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            if (this.adgvconvenios.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(
                        this.adgvconvenios.GetClipboardContent());
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

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void bbtncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region resize
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

        #endregion Fin resize

        private void Mensualidades_MouseMove(object sender, MouseEventArgs e)
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

        private void Mensualidades_Load(object sender, EventArgs e)
        {
            metodosMouseyPaint();
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
            if (g.Name == "adgvconvenios")
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
