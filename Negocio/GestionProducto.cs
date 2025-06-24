using Capa_Entidad;
using Inventario;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class GestionProducto
    {
        private readonly List<IProducto> _productos = new List<IProducto>();

        public IProducto? BuscarProducto(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío", nameof(codigo));

            return _productos.Find(p => p.CodigoProducto == codigo);
        }

        // CREATE: Agregar un nuevo producto
        public void AgregarProducto(Producto nuevoProducto)
        {
            if (nuevoProducto == null)
                throw new ArgumentNullException(nameof(nuevoProducto), "El producto no puede ser nulo");

            // Verificar si el código del producto ya existe
            if (_productos.Any(p => p.CodigoProducto == nuevoProducto.CodigoProducto))
                throw new InvalidOperationException($"Ya existe un producto con el código {nuevoProducto.CodigoProducto}");

            _productos.Add(nuevoProducto);
        }

        // READ: Obtener todos los productos
        public List<IProducto> ObtenerTodosProductos()
        {
            return new List<IProducto>(_productos);
        }

        // UPDATE: Actualizar un producto existente
        public bool ActualizarProducto(Producto productoActualizado)
        {
            if (productoActualizado == null)
                throw new ArgumentNullException(nameof(productoActualizado), "El producto no puede ser nulo");

            var productoExistente = BuscarProducto(productoActualizado.CodigoProducto);
            if (productoExistente == null)
                return false;

            // Actualizar propiedades (excepto código que es el identificador)
            productoExistente.NombreProducto = productoActualizado.NombreProducto;
            productoExistente.CategoriaProducto = productoActualizado.CategoriaProducto;
            productoExistente.EstadoProducto = productoActualizado.EstadoProducto;
            productoExistente.CantidadProducto = productoActualizado.CantidadProducto;
            productoExistente.PrecioProducto = productoActualizado.PrecioProducto;

            return true;
        }

        // DELETE: Eliminar un producto
        public bool EliminarProducto(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío", nameof(codigo));

            var producto = BuscarProducto(codigo);
            if (producto == null)
                return false;

            return _productos.Remove(producto);
        }

        // GESTIÓN DE STOCK

        // Aumentar stock de un producto
        public bool AumentarStock(string codigo, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío", nameof(codigo));

            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad debe ser mayor que cero");

            var producto = BuscarProducto(codigo);
            if (producto == null)
                return false;

            producto.CantidadProducto += cantidad;
            return true;
        }

        // Disminuir stock de un producto (con validación de stock suficiente)
        public bool DisminuirStock(string codigo, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío", nameof(codigo));

            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad debe ser mayor que cero");

            var producto = BuscarProducto(codigo);
            if (producto == null)
                return false;

            if (producto.CantidadProducto < cantidad)
                throw new InvalidOperationException($"No hay suficiente stock. Stock actual: {producto.CantidadProducto}");

            producto.CantidadProducto -= cantidad;
            return true;
        }

        // Verificar disponibilidad de stock
        public bool VerificarDisponibilidad(string codigo, int cantidadRequerida)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío", nameof(codigo));

            if (cantidadRequerida <= 0)
                throw new ArgumentOutOfRangeException(nameof(cantidadRequerida), "La cantidad debe ser mayor que cero");

            var producto = BuscarProducto(codigo);
            return producto != null && producto.CantidadProducto >= cantidadRequerida;
        }
    }
}
