using Capa_Entidad;
namespace CapaDatos
{

    public class VentaDatos
    {
        private readonly string rutaArchivo = "ventas.txt";

        public void GuardarVentasEnTxt(List<Venta> ventas)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                foreach (var venta in ventas)
                {
                    // Línea principal de la venta
                    writer.WriteLine($"VENTA|{venta.IdVenta}|{venta.FechaVenta:yyyy-MM-dd}");

                    // Detalles de la venta
                    foreach (var detalle in venta.Detalles)
                    {
                        writer.WriteLine($"DETALLE|{detalle.Producto.CodigoProducto}|{detalle.Cantidad}|{detalle.PrecioUnitario}");
                    }
                }
            }
        }

        public List<Venta> CargarVentasDesdeTxt(Func<string, IProducto> buscarProducto)
        {
            var ventas = new List<Venta>();
            Venta ventaActual = null;

            foreach (var linea in File.ReadAllLines(rutaArchivo))
            {
                var partes = linea.Split('|');
                if (partes[0] == "VENTA")
                {
                    string id = partes[1];
                    DateTime fecha = DateTime.Parse(partes[2]);
                    ventaActual = new Venta(id, fecha);
                    ventas.Add(ventaActual);
                }
                else if (partes[0] == "DETALLE" && ventaActual != null)
                {
                    string codigoProducto = partes[1];
                    int cantidad = int.Parse(partes[2]);
                    IProducto producto = buscarProducto(codigoProducto); // Método externo para encontrar producto
                    var detalle = new DetalleVenta(producto, cantidad);
                    ventaActual.AgregarDetalle(detalle);
                }
            }

            return ventas;
        }
    }
}
