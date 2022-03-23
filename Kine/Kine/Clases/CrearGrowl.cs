using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Kine.Clases
{
    class CrearGrowl
    {
        public CrearGrowl()
        {
            
        }


        public void crearGrowl(string mensaje, int tm, Form f)
        {
            //tm: 1- success, 2-warning, 3-error
            Users_controls.Growl g = new Users_controls.Growl();
            g.BringToFront();
            List<Control> cg = f.Controls.Cast<Control>().Where(x => x.GetType().ToString().Equals("Kine.Users_controls.Growl")).ToList();
            g.Location = new Point(5, cg.Count != 0 ? (49 + cg[cg.Count - 1].Location.Y) : 50);
            f.Controls.Add(g);
            Color c = new Color();
            Color cl = new Color();
            switch (tm)
            {
                case 1:
                    c = Color.FromArgb(72, 219, 59);
                    cl = Color.Black;
                    break;
                case 2:
                    c = Color.FromArgb(235, 210, 65);
                    cl = Color.Black;
                    break;
                case 3:
                    c = Color.FromArgb(219, 59, 59);
                    cl = Color.White;
                    break;
            }
            g.activar(mensaje, c, cl);
        }
    }
}
