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
    public class MUsuarios
    {
        public void Registrar(Usuarios u)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Nombre", u.Nombre, DbType.String);
            parametro.Add("@Direccion", u.Dirección, DbType.String);
            parametro.Add("@DUI", u.DUI, DbType.String);
            parametro.Add("@NIT", u.NIT, DbType.String);
            parametro.Add("@Usuario", u.Usuario, DbType.String);
            parametro.Add("@Clave", u.Clave, DbType.String);
            parametro.Add("@Fecha", u.Fecha, DbType.DateTime);
            cn.Execute("sp_insert_Usuarios", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void Actualizar(Usuarios u)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Nombre", u.Nombre, DbType.String);
            parametro.Add("@Direccion", u.Dirección, DbType.String);
            parametro.Add("@DUI", u.DUI, DbType.String);
            parametro.Add("@NIT", u.NIT, DbType.String);
            parametro.Add("@Usuario", u.Usuario, DbType.String);
            parametro.Add("@Clave", u.Clave, DbType.String);
            parametro.Add("@Fecha", u.Fecha, DbType.DateTime);
            cn.Execute("sp_update_Usuarios", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Usuarios> Listado()
        {
            List<Usuarios> lista = new List<Usuarios>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Usuarios>("sp_Select_Usuarios", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public void Eliminar(int id)
        {
            DynamicParameters parametro = new DynamicParameters();
            IDbConnection cn = Conexion.Conexion.Conectar();
            parametro.Add("@IdUsuario", id);
            cn.Execute("sp_delete_Usuarios", parametro, commandType: CommandType.StoredProcedure);

        }
    }
}
