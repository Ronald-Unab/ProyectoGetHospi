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
    public class MConsulta
    {
        public void Registrar(Consultas c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();

            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Nombre", c.Nombre, DbType.String);
            parametro.Add("@IdMedico", c.IdMedico, DbType.Int32);
            parametro.Add("@IdArchivo", c.IdArchivo, DbType.Int32);
            cn.Execute("sp_Select_Consultas", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void Actualizar(Consultas c)
        {

        }

        public List<Consultas> Listado()
        {
            List<Consultas> lista = new List<Consultas>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Consultas>("sp_Select_Consultas", commandType: CommandType.StoredProcedure).ToList();
            return lista;
        }

        public void Eliminar(int id)
        {

        }
    }
}
