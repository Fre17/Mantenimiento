using Capa.Entidades.Mantenimiento;
using Capa.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos.Mantenimiento
{
    public class UsuarioDB
    {
        public static List<Usuario> CargarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase() )
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_ConsultaUsuario";

                DataSet ds = db.ExecuteDataSet(comando);
                 

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario aux = new Usuario();
                    aux.Cedula = dr["Cedula"].ToString(); 
                    aux.Nombre = dr["Nombre"].ToString();
                    aux.Apellidos = dr["Apellidos"].ToString();
                    aux.Edad = dr["Edad"].ToString();
                    lista.Add(aux);
                }
            }
            return lista;
        }
        public static void Agregar(Usuario usu)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_CreaUsuario";
                comando.Parameters.AddWithValue("@Nombre", usu.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", usu.Apellidos);
                comando.Parameters.AddWithValue("@Edad", usu.Edad);
                comando.Parameters.AddWithValue("@Cedula", usu.Cedula);
                db.ExecuteNonQuery(comando);
            }
        }
        public static void DeleteUsuario(string cedula)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EliminaUsuario";
                comando.Parameters.AddWithValue("@Cedula", cedula);
                db.ExecuteNonQuery(comando);
            }
        }
        public static void EditarUsuario(Usuario usu)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_EditaUsuario";
                comando.Parameters.AddWithValue("@Nombre", usu.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", usu.Apellidos);
                comando.Parameters.AddWithValue("@Edad", usu.Edad);
                comando.Parameters.AddWithValue("@Cedula", usu.Cedula);
                db.ExecuteNonQuery(comando);
            }
        }
    }
}
