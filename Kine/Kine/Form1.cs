using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kine
{
    public partial class Form1 : Form
    {
        public int xClick = 0, yClick = 0;
        Clases.ConsultaDb db = new Clases.ConsultaDb();
        public Form1()
        {
            InitializeComponent();
            lblruta.Text = db.leerXML();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (lblruta.Text != "")
            {
                New_user.New_User newu = new New_user.New_User("","","","",0,this);
                newu.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una base de datos antes de navegar por la aplicación", "Error de ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btn_data.Visible = false;
            btn_costos.Visible = false;
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
          
            if (lblruta.Text != "")
            {
                Kine.Register_ingresos_diarios.Registrar_ingresos registrar_Ingresos = new Register_ingresos_diarios.Registrar_ingresos();
                registrar_Ingresos.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una base de datos antes de navegar por la aplicación", "Error de ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_data.Visible = false;
            btn_costos.Visible = false;

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (lblruta.Text != "")
            {
                Convenios.Mensualidades mensualidades = new Convenios.Mensualidades();
                mensualidades.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una base de datos antes de navegar por la aplicación", "Error de ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_data.Visible = false;
            btn_costos.Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            if (!btn_data.Visible)
            {
                btn_data.Visible = true;
                btn_costos.Visible = true;
            }
            else
            {
                btn_data.Visible = false;
                btn_costos.Visible = false;
            }
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            if (lblruta.Text != "")
            {
                ingresos.Ingresos ingresos = new ingresos.Ingresos();
                ingresos.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una base de datos antes de navegar por la aplicación", "Error de ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_data.Visible = false;
            btn_costos.Visible = false;
        }

        private void btn_costos_Click(object sender, EventArgs e)
        {
            if (lblruta.Text != "")
            {
                Convenios.Convenios convenios = new Convenios.Convenios();
                convenios.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una base de datos antes de navegar por la aplicación", "Error de ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btn_data.Visible = false;
            btn_costos.Visible = false;
        }

        private void btn_data_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "Desktop";
            openFileDialog1.Filter = "txt  files (*.accdb)|*.accdb|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            {
                if (Path.GetExtension(openFileDialog1.FileName).Equals(".accdb"))
                {
                    lblruta.Text = openFileDialog1.FileName;
                    db.modificarXML(openFileDialog1.FileName);
                    lblruta.Text = db.leerXML();
                }
                else
                {
                    MessageBox.Show("El archivo debe ser de tipo .accdb", "Error de ruta", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            btn_data.Visible = false;
            btn_costos.Visible = false;
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            NuevoUsuario.NuevoUsuario ns = new NuevoUsuario.NuevoUsuario();
            ns.Show();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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
