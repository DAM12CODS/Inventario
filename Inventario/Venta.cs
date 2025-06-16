using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Venta
    {
        public string IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public double Subtotal => Detalles.Sum(d => d.Subtotal);
        public double Impuesto => Subtotal * 0.12;//IVA
        public double Total => Subtotal + Impuesto;

        public Venta(string idVenta, DateTime fecha)
        {
            if (string.IsNullOrWhiteSpace(idVenta)) throw new ArgumentException("El ID no puede estar vacío.");
            IdVenta = idVenta;
            FechaVenta = fecha;
        }

        public void AgregarDetalle(DetalleVenta detalle)
        {
            if (detalle == null) throw new ArgumentNullException(nameof(detalle));
            Detalles.Add(detalle);
        }
    }


}

