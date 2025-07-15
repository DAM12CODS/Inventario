using System;
using Inventario;
namespace Datos
{
    public class GestionDatos
    {
        //Metodo para verificar si un archivo existe, sino lo crea
        public void VerificarArchivo(string archivo, string entrada)
        {
            if (!File.Exists(archivo))
            {
                File.WriteAllText(archivo, entrada + Environment.NewLine);
            }
        }
    }
}
