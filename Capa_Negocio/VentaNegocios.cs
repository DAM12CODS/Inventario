using System;
using Inventario;
using Capa_Entidad;
namespace CapaNegocios
{
    public class VentaNegocios
    {
        public void RegistrarVenta(Venta venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            foreach (var detalle in venta.Detalles)
            {
                Producto producto = detalle.Producto ?? throw new InvalidOperationException("Producto no asignado");

                if (producto.CantidadProducto < detalle.Cantidad)
                    throw new InvalidOperationException($"No hay suficiente stock para el producto {producto.NombreProducto}");

                // Descontar stock
                producto.CantidadProducto -= detalle.Cantidad;
            }

        }

        public DetalleVenta CrearDetalleVenta(Producto producto, int cantidad)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad));

            return new DetalleVenta(producto, cantidad);
        }


    }
}
