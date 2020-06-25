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
    public class MPaciente
    {
        public void Registrar(Pacientes p)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            DynamicParameters parametro = new DynamicParameters();
            parametro.Add("@Nombre", p.Nombre, DbType.String);
            parametro.Add("@Direccion", p.Dirección, DbType.String);
            parametro.Add("@Telefono", p.Telefono, DbType.String);
            parametro.Add("@FechaNacimiento", p.FechaNcimiento, DbType.DateTime);
            parametro.Add("@Sexo", p.Sexo, DbType.String);
            parametro.Add("@CedulaPaciente", p.CédulaPaciente, DbType.Int32);
            parametro.Add("@NumeroRegistro", p.NumRegistro, DbType.Int32);
            parametro.Add("@NombrePadre", p.NombrePadre, DbType.String);
            parametro.Add("@NombreMadre", p.NombreMadre, DbType.String);
            parametro.Add("@GrupoSanguineo", p.GrupoSanguineo, DbType.String);
            cn.Execute("sp_insert_Pacientes", parametro, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void Actualizar(Pacientes p)
        {

        }

        public List<Pacientes> Listado()
        {
            List<Pacientes> lista = new List<Pacientes>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Pacientes>("sp_Select_Pacientes", commandType: CommandType.StoredProcedure).ToList();
            return lista;
        }

        public void Eliminar(int id)
        {
            DynamicParameters parametro = new DynamicParameters();
            IDbConnection cn = Conexion.Conexion.Conectar();
            parametro.Add("@IdPaciente", id);
            cn.Execute("sp_delete_Pacientes", parametro, commandType: CommandType.StoredProcedure);
        }
    }
}
