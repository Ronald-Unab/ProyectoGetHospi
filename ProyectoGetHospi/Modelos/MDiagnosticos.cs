using Dapper;
using ProyectoGetHospi.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Modelos
{
    public class MDiagnosticos
    {
        public void Registrar(Diagnosticos d)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();

            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Diagnostico", d.Diagnostico, DbType.String);
            parametro.Add("@Recetas", d.Recetas, DbType.String);
            parametro.Add("@IdConsulta", d.IdConsulta, DbType.Int32);
            cn.Execute("sp_Select_Diagnosticos", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void Actualizar(Diagnosticos d)
        {

        }

        public List<Diagnosticos> Listado()
        {
            List<Diagnosticos> lista = new List<Diagnosticos>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Diagnosticos>("sp_Select_Diagnosticos", commandType: CommandType.StoredProcedure).ToList();
            return lista;
        }

        public void Eliminar(int id)
        {

        }
    }
}
