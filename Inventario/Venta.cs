using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    internal class Venta
    {
        private string id_Venta;
        private string fecha_Venta;
        private int cantidad_Venta;

        private double precio_Unitario;
        private double subtotal;
        private double impuesto;
        private double total;

        public Venta(string Id_Venta, string Fecha_Venta, int Cantidad_Venta, double Precio_Unitario, double Subtotal, double Impuesto, double Total)
        {
            this.id_Venta = Id_Venta;
            this.fecha_Venta = Fecha_Venta;
            this.cantidad_Venta = Cantidad_Venta;

            this.precio_Unitario = Precio_Unitario;
            this.subtotal = Subtotal;
            this.impuesto = Impuesto;
            this.total = Total;
        }

        public string Id_Venta
        {
            get { return id_Venta; }
            set { id_Venta = value; }
        }

        public string Fecha_Venta
        {
            get { return fecha_Venta; }
            set { fecha_Venta = value; }
        }

        public int Cantidad_Venta
        {
            get { return cantidad_Venta;}
            set { cantidad_Venta= value; }
        }

        public double Precio_Unitario
        {
            get { return precio_Unitario; }
            set { precio_Unitario = value; }
        }

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public double Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

    }
}
