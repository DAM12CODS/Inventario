using Capa_Entidad;
using CapaDatos;
using System;
using System.Collections.Generic;

namespace Capa_Negocio
{
    public class GestionVentas
    {
        private readonly VentaDatos ventaDatos = new VentaDatos();
        private List<Venta> ventas;
        private readonly Func<string, IProducto> buscarProducto;

        // Constructor: recibe la función de búsqueda y carga las ventas desde archivo
        public GestionVentas(Func<string, IProducto> buscarProducto)
        {
            this.buscarProducto = buscarProducto ?? throw new ArgumentNullException(nameof(buscarProducto), "La función de búsqueda de producto no puede ser nula");
            ventas = ventaDatos.CargarVentasDesdeTxt(buscarProducto); // Carga las ventas desde archivo
        }

        // CREATE: Agrega una nueva venta a la lista y la guarda en archivo
        public void AgregarVenta(Venta nuevaVenta)
        {
            if (nuevaVenta == null)
                throw new ArgumentNullException(nameof(nuevaVenta));

            ventas.Add(nuevaVenta);
            ventaDatos.GuardarVentasEnTxt(ventas); // Persiste la nueva lista
        }

        // READ: Devuelve una copia de todas las ventas
        public List<Venta> ObtenerVentas() => new List<Venta>(ventas);

        // Busca una venta específica por su ID
        public Venta? BuscarVentaPorId(string id) => ventas.Find(v => v.IdVenta == id);

        // UPDATE: Reemplaza una venta existente por una versión modificada
        public bool ActualizarVenta(Venta ventaModificada)
        {
            if (ventaModificada == null)
                throw new ArgumentNullException(nameof(ventaModificada));

            var index = ventas.FindIndex(v => v.IdVenta == ventaModificada.IdVenta);
            if (index == -1) return false;

            ventas[index] = ventaModificada;
            ventaDatos.GuardarVentasEnTxt(ventas); // Guarda la lista modificada
            return true;
        }

        // DELETE: Elimina una venta por ID y guarda los cambios
        public bool EliminarVenta(string id)
        {
            var venta = ventas.Find(v => v.IdVenta == id);
            if (venta == null) return false;

            ventas.Remove(venta);
            ventaDatos.GuardarVentasEnTxt(ventas); // Persiste la lista actualizada
            return true;
        }
    }
}
