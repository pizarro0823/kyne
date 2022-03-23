using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace Kine.Convenios
{
    class DAOconvenio
    {
        Clases.SentenciaSQL db = new Clases.SentenciaSQL();

        public DAOconvenio()
        {
        }


        public DataTable consultarConvenioActivo(string cedula, DateTime d)
        {
            DataTable dt = new DataTable();
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@ced", SqlDbType.VarChar, cedula);
            db.valorParametro(p, "@fec", SqlDbType.Date, d);
            dt = db.consultaConParam("SELECT * FROM convenio " +
                                     " WHERE usuario = @ced AND CONVERT(DATE, fecha_fin) >= @fec AND estado = 1 ORDER BY fecha_inicio ASC", p, CommandType.Text);

            return dt;
        }

        public int insertarConvenio(object tipo_convenio, DateTime fecini, DateTime fecfin, string usuario, double valcon)
        {
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@tipc", SqlDbType.Int, tipo_convenio);
            db.valorParametro(p, "@fi", SqlDbType.Date, fecini);
            db.valorParametro(p, "@ff", SqlDbType.Date, fecfin);
            db.valorParametro(p, "@u", SqlDbType.VarChar, usuario);
            db.valorParametro(p, "@v", SqlDbType.Float, valcon);
            int correct = db.ejecutarConParam("INSERT INTO convenio(tipo_convenio,fecha_inicio, fecha_fin, usuario, estado,valor) VALUES(@tipc,@fi,@ff,@u,1,@v)", p, CommandType.Text);
            return correct;
        }

        public DataTable consultarConvenios(DateTime fecdesde, DateTime fechasta, Boolean estado, string col)
        {
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@fecd", SqlDbType.Date, fecdesde);
            db.valorParametro(p, "@fech", SqlDbType.Date, fechasta);
            db.valorParametro(p, "@est", SqlDbType.Bit, estado);
            DataTable dt = db.consultaConParam("SELECT id_convenio,usuario, nombre + ' ' + apellido AS [Nombre usuario], nombre_convenio AS [Tipo convenio], fecha_inicio AS [Fecha ingreso], CONVERT(DATE, fecha_fin) AS [Fecha finalización], cn.valor FROM " +
                                               " convenio cn INNER JOIN tipo_convenio tc ON cn.tipo_convenio = tc.id_tipo_convenio " +
                                               " INNER JOIN usuario usu ON CONVERT(FLOAT, cn.usuario) = CONVERT(FLOAT, usu.cedula) " +
                                               " WHERE CONVERT(DATE, " + col + ") >= @fecd AND  CONVERT(DATE, " + col + ") <=  @fech " +
                                               " AND cn.estado = @est AND id_convenio <> 1 ORDER BY " + col + " ASC; ", p, CommandType.Text);
            return dt;
        }

        public int eliminarConvenio(object id)
        {
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@id", SqlDbType.Int, id);
            int correct = db.ejecutarConParam("UPDATE convenio SET estado = 0 WHERE id_convenio = @id", p, CommandType.Text);
            return correct;
        }

        #region tipo convenio
        public DataTable consultarTipoConvenio()
        {
            DataTable dt = new DataTable();
            dt = db.consulta("SELECT * FROM tipo_convenio WHERE estado = 1");
            return dt;
        }

        public int insertarTipoConvenio(string nombre, string valor, string dias)
        {
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@nombre", SqlDbType.VarChar, nombre);
            db.valorParametro(p, "@valor", SqlDbType.Float, valor);
            db.valorParametro(p, "@dias", SqlDbType.Int, dias);
            int correct = db.ejecutarConParam("INSERT INTO tipo_convenio(nombre_convenio,valor,dias,estado) VALUES(@nombre,@valor,@dias,1)", p, CommandType.Text);
            return correct;
        }

        public int modificarTipoConvenio(string nombre, string valor, string dias, int id)
        {
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@nombre", SqlDbType.VarChar, nombre);
            db.valorParametro(p, "@valor", SqlDbType.Float, valor);
            db.valorParametro(p, "@dias", SqlDbType.Int, dias);
            db.valorParametro(p, "@id", SqlDbType.Int, id);
            int correct = db.ejecutarConParam("UPDATE tipo_convenio SET nombre_convenio = @nombre, valor = @valor, dias = @dias WHERE id_tipo_convenio = @id", p, CommandType.Text);
            return correct;
        }

        public int eliminarTipoConvenio(int id)
        {
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@id", SqlDbType.Int, id);
            int correct = db.ejecutarConParam("UPDATE tipo_convenio SET estado = 0 WHERE id_tipo_convenio = @id", p, CommandType.Text);
            return correct;
        }

        #endregion tipo convenio
    }
}
