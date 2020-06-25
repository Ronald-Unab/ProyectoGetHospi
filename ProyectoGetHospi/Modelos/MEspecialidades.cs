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
    public class MEspecialidades
    {
        public void Registrar(Especialidades e)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();

            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Nombre", e.Nombre, DbType.String);
            parametro.Add("@IdMedico", e.idMedico, DbType.Int32);
            cn.Execute("sp_Select_Especialidades", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void Actualizar (Especialidades e)
        {

        }

        public List<Especialidades> Listado()
        {
            List<Especialidades> lista = new List<Especialidades>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Especialidades>("sp_Select_Especialidades", commandType: CommandType.StoredProcedure).ToList();
            return lista;
        }

        public void Eliminar(int id)
        {

        }
    }
}
