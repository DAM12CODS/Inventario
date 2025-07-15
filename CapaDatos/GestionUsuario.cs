using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Datos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaDatos
{
    public class GestionUsuario
    {
        public List<Usuario> CargarUsuarios(string ruta, string encabezado)
        {
            var verificar = new GestionDatos();
            verificar.VerificarArchivo(ruta, encabezado);
            List<Usuario> usuarios = new List<Usuario>();
            var lineas = File.ReadAllLines(ruta);
            for (int i = 1; i < lineas.Length; i++)
            {
                var partes = lineas[i].Split(';');
                if (partes.Length >= 5)
                {
                    var usuario = new Usuario(partes[0], partes[1], partes[2], partes[3], partes[4]);
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public void RegistrarUsuarios(string ruta, string encabezado, Usuario usuario, List<Usuario> usuarios)
        {
            usuarios = CargarUsuarios(ruta, encabezado);
            try
            {
                using (StreamWriter datos = File.AppendText(ruta))
                {
                    usuarios.Add(usuario);
                    datos.WriteLine($"{usuario.Nombre};{usuario.Apellido};{usuario.Email};{usuario.Pass};{usuario.Rol}");
                }
            }catch (Exception ex)
            {
                throw new Exception("Error al leer el archivo" + ex.Message);
            }
        }
    }
}
