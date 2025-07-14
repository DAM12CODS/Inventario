using System;
using Inventario;
namespace Datos
{
    public class GestionDatos
    {
        public void VerificarArchivo(string archivo, string entrada)
        {
            if (!File.Exists(archivo))
            {
                File.WriteAllText(archivo, entrada + Environment.NewLine);
            }
        }
    }
}
