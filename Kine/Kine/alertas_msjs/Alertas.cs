using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kine.alertas_msjs
{
    public partial class Alertas : Form
    {
        public int xClick = 0, yClick = 0;
        string cedula = "", nombre = "", apellido = "", celular = "";
        Register_ingresos_diarios.Registrar_ingresos fi = new Register_ingresos_diarios.Registrar_ingresos();
        public Alertas(string ced, string nom, string ape, string cel, Register_ingresos_diarios.Registrar_ingresos f)
        {
            InitializeComponent();
            cedula = ced;
            nombre = nom;
            apellido = ape;
            celular = cel;
            fi = f;
            TopMost = true;
            this.CenterToScreen();
        }

        private void Alertas_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnacep_Click(object sender, EventArgs e)
        {
            New_user.New_User nu = new New_user.New_User(cedula, nombre, apellido, celular, 0, fi);
            nu.Show();
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
