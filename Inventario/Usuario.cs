using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _pass;
        private string _rol;

        
        public Usuario(string nombre, string apellido, string email, string pass, string rol)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Pass = pass;
            Rol = rol;
        }

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Email { get; private set; }
        public string Pass { get; private set; }
        public string Rol { get; private set; }
    }
}