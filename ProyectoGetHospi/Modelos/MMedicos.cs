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
    public class MMedicos
    {
        public void Registrar(Médico m)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Nombre", m.Nombre, DbType.String);
            parametro.Add("@Direccion", m.Direccion, DbType.String);
            parametro.Add("@DUI", m.DUI, DbType.String);
            parametro.Add("@Telefono", m.Telefono, DbType.String);
            parametro.Add("@CedulaMedico", m.CedulaMedico, DbType.Int32);
            cn.Execute("sp_insert_Medicos", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void Actualizar(Médico m)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();

            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Nombre", m.Nombre, DbType.String);
            parametro.Add("@Direccion", m.Direccion, DbType.String);
            parametro.Add("@DUI", m.DUI, DbType.String);
            parametro.Add("@Telefono", m.Telefono, DbType.String);
            parametro.Add("@CedulaMedico", m.CedulaMedico, DbType.Int32);
            cn.Execute("sp_update_Medicos", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Médico> Listado()
        {
            List<Médico> lista = new List<Médico>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Médico>("sp_Select_Medicos", commandType: CommandType.StoredProcedure).ToList();
            return lista;
        }

        public void Eliminar(int id)
        {
            DynamicParameters parametro = new DynamicParameters();
            IDbConnection cn = Conexion.Conexion.Conectar();
            parametro.Add("@IdMedico", id);
            cn.Execute("sp_delete_Medicos", parametro, commandType: CommandType.StoredProcedure);
        }
    }
}
