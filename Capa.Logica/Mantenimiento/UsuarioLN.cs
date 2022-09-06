using Capa.Datos.Mantenimiento;
using Capa.Entidades.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Mantenimiento
{
    public class UsuarioLN
    {
        public List<Usuario> CargarUsuarios()
        {
            return UsuarioDB.CargarUsuarios();
        }
        public void Agregar(Usuario usu)
        {
            UsuarioDB.Agregar(usu);
        }
        public void DeleteUsuario(string cedula)
        {
            UsuarioDB.DeleteUsuario(cedula);
        }
        public void EditarUsuario(Usuario usu)
        {
            UsuarioDB.EditarUsuario(usu);
        }
    }
}
