using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APItest.Models
{
    public class AccesoBaseDatos
    {
        public static DataSet ejecutarSQL(string sp, SqlParameter[] parametros, string conexionString)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                using (SqlCommand cmd = new SqlCommand(sp, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter parametro in parametros)
                    {
                        cmd.Parameters.Add(parametro);
                    }

                    conexion.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    cmd.Parameters.Clear();

                    return ds;
                }
            }
        }
    }
}
