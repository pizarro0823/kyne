using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Kine.ingresos
{
    class DAOingresos
    {
        Clases.SentenciaSQL db = new Clases.SentenciaSQL();
        public DAOingresos()
        {

        }

        public DataTable consultarRegistro(DateTime fechadesde, DateTime fechahasta, Boolean estado)
        {
            List<SqlParameter> p = new List<SqlParameter>();
            db.valorParametro(p, "@fecini", SqlDbType.Date, fechadesde);
            db.valorParametro(p, "@fecfin", SqlDbType.Date, fechahasta);
            db.valorParametro(p, "@est", SqlDbType.Bit, estado);
            db.valorParametro(p, "@fecini2", SqlDbType.Date, fechadesde);
            db.valorParametro(p, "@fecfin2", SqlDbType.Date, fechahasta);
            db.valorParametro(p, "@est2", SqlDbType.Bit, estado);
            DataTable dt = db.consultaConParam("SELECT usuario, nombre + ' ' + apellido AS [Nombre usuario], nombre_convenio AS [Tipo Ingreso], fecha_inicio AS [Fecha ingreso], cn.valor " +
                                               " FROM convenio AS cn INNER JOIN tipo_convenio AS tc ON cn.tipo_convenio = tc.id_tipo_convenio INNER JOIN usuario AS usu ON CONVERT(FLOAT, cn.usuario) = CONVERT(FLOAT, usu.cedula) " +
                                               " WHERE CONVERT(DATE, fecha_inicio) >=  @fecini AND CONVERT(DATE, fecha_inicio) <= @fecfin AND " +
                                               " cn.estado = @est AND id_convenio <> 1 " +
                                               " UNION " +
                                               " SELECT r.cedula, u.nombre + ' ' + u.apellido, 'clase diaria', fecha_reg, costo_clase " +
                                               " FROM registro_diario AS r INNER JOIN usuario AS u ON CONVERT(FLOAT, r.cedula) = CONVERT(FLOAT, u.cedula) " +
                                               " WHERE CONVERT(DATE, r.fecha_reg) >=  @fecini2 AND  CONVERT(DATE, r.fecha_reg) <= @fecfin2 AND  r.estado = @est2 AND convenio_asociado = 1 " +
                                               " ORDER BY [fecha ingreso] ASC;", p, CommandType.Text);

            return dt;
        }


    }
}
