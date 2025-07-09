using System;
using Inventario;
using Capa_Entidad;
using CapaDatos; 
namespace CapaNegocios
{
    public class VentaNegocios
    {
        public void RegistrarVenta(Venta venta, string archivoProductosCSV, string encabezadoCSV, List<Producto> productos)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            if (venta.Detalles == null || !venta.Detalles.Any())
                throw new InvalidOperationException("La venta no contiene productos.");

            foreach (var detalle in venta.Detalles)
            {
                Producto producto = detalle.Producto ?? throw new InvalidOperationException("Producto no asignado");

                if (producto.CantidadProducto < detalle.Cantidad)
                    throw new InvalidOperationException($"No hay suficiente stock para el producto {producto.NombreProducto}");

                // Descontar stock
                producto.CantidadProducto -= detalle.Cantidad;
            }

            // Guardar cambios en archivo CSV (Excel)
            Datos.GestionProducto gestor = new Datos.GestionProducto();

            string tempFile = Path.GetTempFileName();
            gestor.ReescribirArchivo(tempFile, archivoProductosCSV, encabezadoCSV, productos);
        }

        public DetalleVenta CrearDetalleVenta(Producto producto, int cantidad)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad debe ser mayor que cero.");

            return new DetalleVenta(producto, cantidad);
        }


    }
}
