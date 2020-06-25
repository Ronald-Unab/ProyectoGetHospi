
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace ProyectoGetHospi.Conexion
{
    public static class Conexion
    {
        public static IDbConnection Conectar()
        {
            IDbConnection con;
            string cadena = "Data Source=localhost;" +
                "Initial Catalog=GetHospi;" +
                "Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            con = cn;
            return con;
       
        }
    }
}
