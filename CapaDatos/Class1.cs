// Importación de entidades y librerías necesarias
using Capa_Entidad;
using DocumentFormat.OpenXml.Drawing;     // NO se está usando realmente aquí
using DocumentFormat.OpenXml.Math;        // Tampoco se usa
using SpreadsheetLight;                   // Tampoco se usa en este código
using System.Data;                        // Tampoco se usa aquí
using System.Security.Principal;          // No se usa

namespace CapaDatos
{
    public class VentaDatos
    {
        // Ruta donde se guardará el archivo de ventas
        private readonly string rutaArchivo = "ventas.txt";

        /// <summary>
        /// Guarda una lista de ventas en un archivo de texto.
        /// Cada venta y sus detalles se escriben en líneas separadas con un formato específico.
        /// </summary>
        public void GuardarVentasEnTxt(List<Venta> ventas)
        {
            // StreamWriter permite escribir texto en un archivo (modo sobrescribir: false)
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                // Recorremos cada venta en la lista
                foreach (var venta in ventas)
                {
                    // Guardamos los datos principales de la venta en una línea: ID y fecha
                    writer.WriteLine($"VENTA|{venta.IdVenta}|{venta.FechaVenta:yyyy-MM-dd}");

                    // Ahora guardamos los detalles de esa venta en líneas aparte
                    foreach (var detalle in venta.Detalles)
                    {
                        writer.WriteLine($"DETALLE|{detalle.Producto.CodigoProducto}|{detalle.Cantidad}|{detalle.PrecioUnitario}");
                    }
                }
            }
        }

        /// <summary>
        /// Carga ventas desde un archivo de texto y las reconstruye en memoria.
        /// Requiere una función externa que permita obtener el producto a partir de su código.
        /// </summary>
        public List<Venta> CargarVentasDesdeTxt(Func<string, IProducto> buscarProducto)
        {
            var ventas = new List<Venta>();    // Lista que se va a devolver
            Venta ventaActual = null;          // Variable temporal para armar cada venta

            // Leemos línea por línea el archivo de texto
            foreach (var linea in File.ReadAllLines(rutaArchivo))
            {
                var partes = linea.Split('|'); // Dividimos la línea en partes separadas por '|'

                if (partes[0] == "VENTA")
                {
                    // Creamos una nueva venta con los datos leídos
                    string id = partes[1];
                    DateTime fecha = DateTime.Parse(partes[2]);
                    ventaActual = new Venta(id, fecha);
                    ventas.Add(ventaActual); // Agregamos la venta a la lista
                }
                else if (partes[0] == "DETALLE" && ventaActual != null)
                {
                    // Leemos los datos del detalle y buscamos el producto con el código
                    string codigoProducto = partes[1];
                    int cantidad = int.Parse(partes[2]);

                    // buscarProducto es una función pasada por parámetro para obtener el producto
                    IProducto producto = buscarProducto(codigoProducto);

                    // Creamos el detalle y lo agregamos a la venta actual
                    var detalle = new DetalleVenta(producto, cantidad);
                    ventaActual.AgregarDetalle(detalle);
                }
            }

            return ventas; // Devolvemos la lista completa
        }
    }
}
