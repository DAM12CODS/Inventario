using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class DetalleVenta
    {
        public IProducto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario => Producto.PrecioProducto;
        public double Subtotal => Cantidad * PrecioUnitario;

        public DetalleVenta(IProducto producto, int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor a cero.");
            }
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto));
            }
            Producto = producto;
            Cantidad = cantidad;
        }
    }
}
