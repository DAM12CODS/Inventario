using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    // Clase que representa una venta realizada
    public class Venta
    {
        // Identificador único de la venta
        public string IdVenta { get; set; }

        // Fecha en que se realizó la venta
        public DateTime FechaVenta { get; set; }

        // Lista de todos los detalles (productos o servicios) asociados a la venta
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        // Propiedad calculada que devuelve la suma de los subtotales de todos los detalles
        public double Subtotal => Detalles.Sum(d => d.Subtotal);

        // Propiedad calculada que aplica el impuesto (IVA del 12%) al subtotal
        public double Impuesto => Subtotal * 0.12;

        // Propiedad calculada que representa el valor total de la venta (subtotal + impuesto)
        public double Total => Subtotal + Impuesto;

        // Constructor que inicializa la venta con su ID y fecha
        public Venta(string idVenta, DateTime fecha)
        {
            // Validación: el ID de la venta no puede estar vacío o contener solo espacios
            if (string.IsNullOrWhiteSpace(idVenta)) throw new ArgumentException("El ID no puede estar vacío.");

            IdVenta = idVenta;
            FechaVenta = fecha;
        }

        // Método para agregar un detalle (producto o servicio) a la venta
        public void AgregarDetalle(DetalleVenta detalle)
        {
            // Validación: no se permite agregar un detalle nulo
            if (detalle == null) throw new ArgumentNullException(nameof(detalle));

            // Agrega el detalle a la lista de detalles
            Detalles.Add(detalle);
        }
    }
}
