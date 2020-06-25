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
    public class MArchivos
    {
        public void Registrar(Archivo a)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();

            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Peso", a.Peso, DbType.String);
            parametro.Add("@PresionArterial", a.PresionArterial, DbType.String);
            parametro.Add("@Temperatura", a.Temperatura, DbType.String);
            parametro.Add("@IdPaciente", a.IdPaciente, DbType.String);

            cn.Close();
        }

        public void Actualizar(Archivo a)
        {

        }

        public List<Archivo> Listado()
        {
            List<Archivo> lista = new List<Archivo>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Archivo>("sp_Select_Archivos", commandType:CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public void Eliminar(int id)
        {

        }
    }
}
