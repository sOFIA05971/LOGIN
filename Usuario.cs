using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN
{
    internal class Usuario
    {

        private static List<Usuario> usuarios = new List<Usuario>
        {
        new Usuario{NombreUsuario = "Admin", Contrasenia="1234"},
        new Usuario{NombreUsuario = "Yeyito", Contrasenia="0000"},
        new Usuario{NombreUsuario = "Imael", Contrasenia="1111"},

};
        public Usuario() { }

        public List<Usuario> Obtenerusuario()
        {
            return usuarios;
        }

        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
