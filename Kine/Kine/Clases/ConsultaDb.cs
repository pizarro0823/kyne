using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Xml;

namespace Kine.Clases
{
    class ConsultaDb
    {
        string rutaArch = "";
        OleDbConnection connString;
        public ConsultaDb()
        {
            rutaArch = leerXML();
            connString = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArch + ";Persist Security Info=False;");
        }

        public DataTable consulta(string sentencia)
        {
            DataTable dt = new DataTable();
            connString.Open();
            OleDbCommand cmd = new OleDbCommand(sentencia, connString);
            cmd.CommandTimeout = 70000;
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            ad.Fill(dt);
            connString.Close();
            return dt;
        }

        public DataTable consultaConParam(string sentencia, List<OleDbParameter> p, CommandType ct)
        {
            DataTable dt = new DataTable();
            connString.Open();
            OleDbCommand cmd = new OleDbCommand(sentencia, connString);
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(p.ToArray());
            cmd.CommandTimeout = 70000;
            OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
            ad.Fill(dt);
            cmd.Parameters.Clear();
            connString.Close();
            return dt;
        }

        public int ejecutarConParam(string sentencia, List<OleDbParameter> p, CommandType ct)
        {
            int ejec = 0;
            connString.Open();
            OleDbCommand cmd = new OleDbCommand(sentencia, connString);
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(p.ToArray());
            cmd.CommandTimeout = 70000;
            ejec = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            connString.Close();
            return ejec;
        }

        public int ejecutarSent(string sentencia)
        {
            int ejec = 0;
            connString.Open();
            OleDbCommand cmd = new OleDbCommand(sentencia, connString);
            cmd.CommandTimeout = 70000;
            ejec = cmd.ExecuteNonQuery();
            connString.Close();
            return ejec;
        }

        public void valorParametro(List<OleDbParameter> lp, string nombre,OleDbType tipod, object valor)
        {
            OleDbParameter p = new OleDbParameter();
            p.ParameterName = nombre;
            p.OleDbType = tipod;
            p.Value = valor;
            lp.Add(p);
        }

        public string leerXML()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(@"XML\directory.xml");
            return ds.Tables[0].Rows[0]["file"].ToString();
        }

        public void modificarXML(string direccion)
        {
            XmlDocument d = new XmlDocument();
            d.Load(@"XML\directory.xml");
            XmlElement el = d.DocumentElement;
            XmlNode nodold = el.SelectNodes("file").Item(0);

            XmlElement eln = d.CreateElement("file");
            eln.InnerText = direccion;

            XmlNode nodnew = eln;
            el.ReplaceChild(nodnew, nodold);
            d.Save(@"XML\directory.xml");
            rutaArch = leerXML();
            connString = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArch + ";Persist Security Info=False;");
        }



    }
}
