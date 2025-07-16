// <copyright file="GestioProducto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Inventario;

    /// <summary>
    /// Clase para la gestión de productos.
    /// </summary>
    public class GestionProducto
    {
        /// <summary>
        /// Carga los productos desde un archivo CSV.
        /// </summary>
        /// <param name="archivo">Ruta del archivo CSV a leer.</param>
        /// <param name="entrada">Encabezado esperado del archivo.</param>
        /// <param name="productos">Lista donde se cargarán los productos.</param>
        public void CargarProductos(string archivo, string entrada, List<Producto> productos)
        {
            try
            {
                productos.Clear();
                var verificar = new GestionDatos();
                verificar.VerificarArchivo(archivo, entrada);

                using (StreamReader archivoEntrada = new StreamReader(archivo))
                {
                    archivoEntrada.ReadLine(); // Saltar encabezado
                    string? linea;

                    while ((linea = archivoEntrada.ReadLine()) != null)
                    {
                        string[] items = linea.Split(';');
                        if (items.Length >= 5 &&
                            int.TryParse(items[3], out int cantidad) &&
                            double.TryParse(items[4], out double precio))
                        {
                            var producto = new Producto(items[0], items[1], items[2], cantidad, precio);
                            productos.Add(producto);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                throw new Exception("Error al leer el archivo: " + e.Message);
            }
        }

        /// <summary>
        /// Agrega un producto al archivo y la lista.
        /// </summary>
        /// <param name="archivo">Ruta del archivo donde se agregará el producto.</param>
        /// <param name="entrada">Encabezado del archivo.</param>
        /// <param name="productos">Lista de productos existente.</param>
        /// <param name="codigo">Código del nuevo producto.</param>
        /// <param name="nombre">Nombre del nuevo producto.</param>
        /// <param name="categoria">Categoría del nuevo producto.</param>
        /// <param name="cantidad">Cantidad del nuevo producto.</param>
        /// <param name="precio">Precio del nuevo producto.</param>
        public void AgregarProducto(string archivo, string entrada, List<Producto> productos, string codigo, string nombre, string categoria, int cantidad, double precio)
        {
            this.CargarProductos(archivo, entrada, productos);

            try
            {
                using (StreamWriter datos = File.AppendText(archivo))
                {
                    Producto nuevoProducto = new Producto(codigo, nombre, categoria, cantidad, precio);
                    productos.Add(nuevoProducto);
                    datos.WriteLine($"{codigo};{nombre};{categoria};{cantidad};{precio}");
                }
            }
            catch (IOException e)
            {
                throw new Exception("Error al escribir en el archivo: " + e.Message);
            }
        }

        /// <summary>
        /// Actualiza un producto existente en el archivo y la lista.
        /// </summary>
        /// <param name="archivo">Ruta del archivo donde se actualiza el producto.</param>
        /// <param name="entrada">Encabezado del archivo.</param>
        /// <param name="productos">Lista de productos existente.</param>
        /// <param name="codigo">Código del producto a actualizar.</param>
        /// <param name="nombre">Nuevo nombre del producto.</param>
        /// <param name="categoria">Nueva categoría del producto.</param>
        /// <param name="cantidad">Nueva cantidad del producto.</param>
        /// <param name="precio">Nuevo precio del producto.</param>
        public void ActualizarProducto(string archivo, string entrada, List<Producto> productos, string codigo, string nombre, string categoria, int cantidad, double precio)
        {
            string tempFile = Path.GetTempFileName();

            try
            {
                int i = productos.FindIndex(p => p.CodigoProducto.Equals(codigo, StringComparison.OrdinalIgnoreCase));
                if (i >= 0)
                {
                    productos[i].NombreProducto = nombre;
                    productos[i].CategoriaProducto = categoria;
                    productos[i].CantidadProducto = cantidad;
                    productos[i].PrecioProducto = precio;
                }
                else
                {
                    throw new Exception("Producto no encontrado");
                }

                this.ReescribirArchivo(tempFile, archivo, entrada, productos);
            }
            catch (IOException e)
            {
                throw new Exception("Error al actualizar el archivo: " + e.Message);
            }
        }

        /// <summary>
        /// Elimina un producto del archivo y la lista.
        /// </summary>
        /// <param name="archivo">Ruta del archivo donde se eliminará el producto.</param>
        /// <param name="entrada">Encabezado del archivo.</param>
        /// <param name="productos">Lista de productos existente.</param>
        /// <param name="codigo">Código del producto a eliminar.</param>
        public void EliminarProducto(string archivo, string entrada, List<Producto> productos, string codigo)
        {
            this.CargarProductos(archivo, entrada, productos);
            string tempFile = Path.GetTempFileName();

            try
            {
                int i = productos.FindIndex(p => p.CodigoProducto.Equals(codigo, StringComparison.OrdinalIgnoreCase));
                if (i >= 0)
                {
                    productos.RemoveAt(i);
                }
                else
                {
                    throw new Exception("Producto no encontrado");
                }

                this.ReescribirArchivo(tempFile, archivo, entrada, productos);
            }
            catch (IOException e)
            {
                throw new Exception("Error al eliminar el producto: " + e.Message);
            }
        }

        /// <summary>
        /// Reescribe el archivo con la lista actualizada de productos.
        /// </summary>
        /// <param name="tempFile">Ruta del archivo temporal que se utilizará para reescribir.</param>
        /// <param name="archivo">Ruta del archivo original a reemplazar.</param>
        /// <param name="entrada">Encabezado del archivo.</param>
        /// <param name="productos">Lista de productos actualizada.</param>
        public void ReescribirArchivo(string tempFile, string archivo, string entrada, List<Producto> productos)
        {
            using (StreamWriter fstemp = new StreamWriter(tempFile))
            {
                fstemp.WriteLine(entrada);
                foreach (var producto in productos)
                {
                    fstemp.WriteLine($"{producto.CodigoProducto};{producto.NombreProducto};{producto.CategoriaProducto};{producto.CantidadProducto};{producto.PrecioProducto}");
                }
            }

            File.Delete(archivo);
            File.Move(tempFile, archivo);
        }
    }
}
