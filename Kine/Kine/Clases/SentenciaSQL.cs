using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace Kine.Clases
{
    class SentenciaSQL
    {
        string connection;
        public SentenciaSQL()
        {
            connection = "data source=(localdb)\\Servidor;initial catalog=KINE;persist security info=True;user id=SA;password=adminsa1;MultipleActiveResultSets=True ";
            //connection = "data source=(localdb)\\Servidor;initial catalog=KINE;persist security info=True;user id=SA;password=1234;MultipleActiveResultSets=True ";
        }

        public DataTable consulta(string sentencia)
        {
            DataTable dt = new DataTable();
            SqlConnection cnx = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sentencia, cnx);
            cmd.CommandTimeout = 70000;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            return dt;
        }
        public void volcarTabla(string tabla, DataTable dt)
        {
           
            using (var sqlBulk = new SqlBulkCopy(connection))
            {
                sqlBulk.DestinationTableName = tabla;
                sqlBulk.BulkCopyTimeout = 70000;
                sqlBulk.WriteToServer(dt);
            }
        }
        public int ejecutarSentencia(string sentencia)
        {
            int exc = 0;
            SqlConnection cnx = new SqlConnection(connection);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(sentencia, cnx);
            cmd.CommandTimeout = 70000;
            exc = cmd.ExecuteNonQuery();
            cnx.Close();
            return exc;
        }

        public DataTable consultaConParam(string sentencia, List<SqlParameter> p, CommandType ct)
        {
            DataTable dt = new DataTable();
            SqlConnection cnx = new SqlConnection(connection);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(sentencia, cnx);
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(p.ToArray());
            cmd.CommandTimeout = 70000;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            cmd.Parameters.Clear();
            cnx.Close();
            return dt;

        }

        public int ejecutarConParam(string sentencia, List<SqlParameter> p, CommandType ct)
        {
            int exc = 0;
            SqlConnection cnx = new SqlConnection(connection);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(sentencia, cnx);
            cmd.CommandType = ct;
            cmd.Parameters.AddRange(p.ToArray());
            cmd.CommandTimeout = 70000;
            exc = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cnx.Close();
            return exc;

        }

        public void valorParametro(List<SqlParameter> lp, string nombre, SqlDbType tipoDato, object valor)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.SqlDbType = tipoDato;
            p.Value = valor;
            lp.Add(p);
        }

        public bool probarConexion()
        {
            bool r;
            SqlConnection cnx = new SqlConnection();
            try
            {
                cnx.ConnectionString = connection;
                cnx.Open();
            }
            catch (Exception ew)
            {

            }

            if (cnx.State == ConnectionState.Open)
            {
                r = true;
            }
            else
            {
                r = false;
            }
            return r;
        }

        public SqlDbType DataTypeASqlDbType(string datatype)
        {
            SqlDbType dbt = new SqlDbType();
            if (datatype.Equals("System.String"))
            {
                dbt = SqlDbType.VarChar;
            }
            else if (datatype.Equals("System.DateTime"))
            {
                dbt = SqlDbType.DateTime;
            }
            else if (datatype.Equals("System.Double"))
            {
                dbt = SqlDbType.Float;
            }
            else if (datatype.Equals("System.Int32"))
            {
                dbt = SqlDbType.Int;
            }
            else if (datatype.Equals("System.Decimal"))
            {
                dbt = SqlDbType.Decimal;
            }
            else if (datatype.Equals("System.Byte[]"))
            {
                dbt = SqlDbType.VarBinary;
            }

            return dbt;
        }

        public void modificarXml(string nodo, string valor)
        {
            XmlDocument d = new XmlDocument();
            d.Load(@"XML\datosBase.xml");
            XmlElement el = d.DocumentElement;
            XmlNode nodold = el.SelectNodes("datospordefecto").Item(0);
            XmlNode nodoldnode = nodold.SelectNodes(nodo).Item(0);
            XmlElement id = d.CreateElement(nodo);
            id.InnerText = valor;
            nodold.ReplaceChild(id, nodoldnode);
            d.Save(@"XML\datosBase.xml");
        }

        public void crearNode(string nombrenode, string dato)
        {
            XmlDocument d = new XmlDocument();
            d.Load(@"XML\datosBase.xml");
            XmlElement el = d.DocumentElement;
            XmlNode n = el.SelectNodes("datospordefecto").Item(0);
            XmlElement nn = d.CreateElement(nombrenode);
            nn.InnerText = dato;
            n.AppendChild(nn);
            d.Save(@"XML\datosBase.xml");
        }
        public string[] consultarNode(string nodepbusc, string nodehbusc)
        {
            string[] ds;
            XmlDocument d = new XmlDocument();
            d.Load(@"XML\datosBase.xml");
            XmlElement el = d.DocumentElement;
            XmlNode n = el.SelectNodes(nodepbusc).Item(0);
            XmlNodeList nl = n.SelectNodes(nodehbusc);
            ds = new string[nl.Count];
            for (int i = 0; i < nl.Count ;i++)
            {
                ds[i] = nl[i].InnerText;
            }
            return ds;
        }


    }
}
