using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kine.Convenios
{
    public partial class Convenios : Form
    {
        public int xClick = 0, yClick = 0;
        DAOconvenio daoconv = new DAOconvenio();
        DataTable dttipoconv = new DataTable();
        Clases.CrearGrowl growl = new Clases.CrearGrowl();
        int id_elim = 0;
        public Convenios()
        {
            InitializeComponent();
            ConsultarInfo();
            btn_convenio_Save.Visible = true;
            btn_convenio_Modificar.Visible = false;
            btn_delete.Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_convenio_Save_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                int c = daoconv.insertarTipoConvenio(txt_tipo_convenio.Text, txt_convenio_valor.Text, txt_convenio_dias.Text);
                if (c != 0)
                {
                    ConsultarInfo();
                    reiniciarControles();
                    growl.crearGrowl("Datos guardados correctamente", 1, this);
                }
                else
                {
                    growl.crearGrowl("Error al modificar los datos", 3, this);
                }
            }
            else
            {
                growl.crearGrowl("Debe llenar los campos requeridos",2,this);
            }
        }

        private void btn_convenio_Modificar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                int c = daoconv.modificarTipoConvenio(txt_tipo_convenio.Text, txt_convenio_valor.Text, txt_convenio_dias.Text, id_elim);
                if (c != 0)
                {
                    ConsultarInfo();
                    reiniciarControles();
                    growl.crearGrowl("Datos modificados correctamente", 1, this);
                }
                else
                {
                    growl.crearGrowl("Error al modificar los datos", 3, this);
                }
            }
            else
            {
                growl.crearGrowl("Debe llenar los campos requeridos", 2, this);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea eliminar la información?","Eliminar tipo convenio",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int c = daoconv.eliminarTipoConvenio(id_elim);
                if (c != 0)
                {
                    ConsultarInfo();
                    reiniciarControles();
                    growl.crearGrowl("Datos eliminados correctamente", 1, this);
                }
                else
                {
                    growl.crearGrowl("Error al eliminar los datos", 3, this);
                }
            }
        }

        public Boolean validarCampos()
        {
            Boolean correct = true;
            if (txt_tipo_convenio.Text.Trim() == "")
            {
                correct = false;
                txt_tipo_convenio.BorderColor = Color.Red;
                txt_tipo_convenio.BorderSize = 4;
            }
            else
            {
                txt_tipo_convenio.BorderColor = Color.FromArgb(204, 153, 0);
                txt_tipo_convenio.BorderSize = 1;
            }

            int v = 0;
            if (txt_convenio_valor.Text.Trim() != "")
            {
                if (!int.TryParse(txt_convenio_valor.Text,out v))
                {
                    correct = false;
                    txt_convenio_valor.BorderColor = Color.Red;
                    txt_convenio_valor.BorderSize = 4;
                }
                else
                {
                    txt_convenio_valor.BorderColor = Color.FromArgb(204, 153, 0);
                    txt_convenio_valor.BorderSize = 1;
                }
            }
            else
            {
                correct = false;
                txt_convenio_valor.BorderColor = Color.Red;
                txt_convenio_valor.BorderSize = 4;
            }

            if (txt_convenio_dias.Text.Trim() != "")
            {
                if (!int.TryParse(txt_convenio_dias.Text, out v))
                {
                    correct = false;
                    txt_convenio_dias.BorderColor = Color.Red;
                    txt_convenio_dias.BorderSize = 4;
                }
                else
                {
                    txt_convenio_dias.BorderColor = Color.FromArgb(204, 153, 0);
                    txt_convenio_dias.BorderSize = 1;
                }
            }
            else
            {
                correct = false;
                txt_convenio_dias.BorderColor = Color.Red;
                txt_convenio_dias.BorderSize = 4;
            }
            return correct;
        }

        private void advancedDataGridView1_Click(object sender, EventArgs e)
        {
            if (adgvconv.Rows.Count != 0)
            {
                if (adgvconv.CurrentCell.ColumnIndex == 0)
                {
                    SendKeys.Send("{RIGHT}");
                }
            }
        }

        private void advancedDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(adgvconv.Rows[e.RowIndex].Cells[0].Value))
            {
                List<DataGridViewRow> rs = adgvconv.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells[0].Value) & x.Index != e.RowIndex).ToList();
                if (rs.Count != 0)
                {
                    rs[0].Cells[0].Value = false;
                }
                txt_tipo_convenio.Text = adgvconv.Rows[e.RowIndex].Cells["nombre_convenio"].Value.ToString();
                txt_convenio_valor.Text = adgvconv.Rows[e.RowIndex].Cells["valor"].Value.ToString();
                txt_convenio_dias.Text = adgvconv.Rows[e.RowIndex].Cells["dias"].Value.ToString();
                btn_convenio_Save.Visible = false;
                btn_convenio_Modificar.Visible = true;
                id_elim = Convert.ToInt32(adgvconv.Rows[e.RowIndex].Cells["id_tipo_convenio"].Value);
                if (id_elim != 1)
                {
                    btn_delete.Visible = true;
                    txt_tipo_convenio.Enabled = true;
                    txt_convenio_dias.Enabled = true;
                }
                else
                {
                    txt_tipo_convenio.Enabled = false;
                    txt_convenio_dias.Enabled = false;
                    btn_delete.Visible = false;
                }
            }
            else
            {
                reiniciarControles();
            }
        }

        public void reiniciarControles()
        {
            txt_tipo_convenio.Text = "";
            txt_convenio_valor.Text = "";
            txt_convenio_dias.Text = "";
            btn_convenio_Save.Visible = true;
            btn_convenio_Modificar.Visible = false;
            btn_delete.Visible = false;
            txt_tipo_convenio.Enabled = true;
            txt_convenio_dias.Enabled = true;
        }

        public void ConsultarInfo()
        {
            dttipoconv = daoconv.consultarTipoConvenio();
            adgvconv.Columns.Clear();
            llenarGrid(adgvconv, dttipoconv);
            adgvconv.Columns["id_tipo_convenio"].Visible = false;
            adgvconv.Columns["estado"].Visible = false;
            for (int i = 0; i < adgvconv.Columns.Count; i++)
            {
                adgvconv.Columns[i].ReadOnly = true;
            }
            DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();
            ch.Name = "ch";
            ch.Width = 20;
            adgvconv.Columns.Insert(0, ch);
        }

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
            if (g.Name == "adgvconv")
            {
                bs = bsconv;
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

        private void gen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X;
                yClick = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - xClick);
                this.Top = this.Top + (e.Y - yClick);
            }
        }

    }
}
