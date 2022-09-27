using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Modelo
{
    public class sentencias
    {
        conexion con = new conexion();

        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {

                OdbcCommand cmd = new OdbcCommand(sql, con.Conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
        }


        public void eliminar(string tabla, string condicion, int campo)
        {

            try
            {

                string sql = "delete from " + tabla + " where " + condicion + " " + campo + " ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.Conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }


        }


        public OdbcDataAdapter llenartabla(string tabla)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.Conexion());
            return datatable;
        }

        public void actualizar(string dato, string condicion, string tabla, int num)
        {

            string sql = "Update " + tabla + " " + dato + " where " + condicion + " " + num + "; ";
            OdbcCommand cmd = new OdbcCommand(sql, con.Conexion());
            cmd.ExecuteNonQuery();

        }






    }
}
