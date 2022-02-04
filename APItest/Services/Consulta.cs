using APItest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APItest.Services
{
    public class Consulta
    {
        public static DataSet Query(Parametros parametros, string conexion)
        {
            SqlParameter[] sqlparams =
            {
                new SqlParameter("@nombre",parametros.Nombre),
   
            };
            return AccesoBaseDatos.ejecutarSQL("SpconsultaPersona", sqlparams, conexion);
        }
    }
}
