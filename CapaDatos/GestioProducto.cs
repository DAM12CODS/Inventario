using DocumentFormat.OpenXml.Drawing.Charts;
using Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace Datos
{
    public class GestionProducto
    {
        public void CargarProductos(string archivo, string entrada, List<Producto> productos)
        {

            try
            {
                productos.Clear();
                var verificar = new GestionDatos();
                verificar.VerificarArchivo(archivo, entrada);
                using (StreamReader archivoEntrada = new StreamReader(archivo))
                {
                    string linea;
                    //Lee la primera linea
                    archivoEntrada.ReadLine();
                    //Lee cada linea
                    while ((linea = archivoEntrada.ReadLine()) != null)
                    {
                        string[] items = linea.Split(';'); //Leer hasta el delimitador
                        if (items.Length >= 5)
                        {
                           // bool disponible;
                            int cantidad;
                            double precio;
                            // Intenta convertir los valores (maneja posibles errores de formato)
                         //   bool.TryParse(items[3], out disponible);
                            int.TryParse(items[3], out cantidad);
                            double.TryParse(items[4], out precio);
                            var producto = new Producto(
                                items[0],
                                items[1],
                                items[2],
                               // disponible,
                                cantidad,
                                precio
                                );
                            productos.Add(producto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void AgregarProducto(string archivo, string entrada, List<Producto> productos, string codigo,
            string nombre, string categoria, int cantidad, double precio)
        {
            var verificar = new GestionDatos();
            verificar.VerificarArchivo(archivo, entrada);
            CargarProductos(archivo, entrada, productos);
            try
            {
                using (StreamWriter datos = File.AppendText(archivo))
                {
                    Producto nuevoProducto = new Producto(codigo, nombre, categoria, cantidad, precio);
                    productos.Add(nuevoProducto);
                    // Escribir en el archivo
                    datos.WriteLine($"{codigo};{nombre};{categoria};{cantidad};{precio}");
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ActualizarProducto(string archivo, string entrada, List<Producto> productos, string codigo,
            string nombre, string categoria, int cantidad, double precio)
        {
            CargarProductos(archivo, entrada, productos);
            string tempFile = Path.GetTempFileName();
            try
            {
               // Producto productoEncontrado = productos.FirstOrDefault(p => p.CodigoProducto == codigo);
                int i = productos.FindIndex(p => p.CodigoProducto.Equals(codigo, StringComparison.OrdinalIgnoreCase));

                if (i >= 0)
                {
                    productos[i].NombreProducto = nombre;
                    productos[i].CategoriaProducto = categoria;
                    productos[i].CantidadProducto = cantidad;
                    productos[i].PrecioProducto = precio;
                } else
                {
                    throw new Exception("Producto no encontrado");
                }

                    using (StreamWriter fstemp = new StreamWriter(tempFile))
                    {
                        // Escribir encabezado
                        fstemp.WriteLine(entrada);

                        // Escribir todos los productos
                        foreach (var producto in productos)
                        {
                        fstemp.WriteLine($"{producto.CodigoProducto};{producto.NombreProducto};{producto.CategoriaProducto};{producto.CantidadProducto};{producto.PrecioProducto}");
                    }
                }
                // Reemplazar archivo original
                File.Delete(archivo);
                File.Move(tempFile, archivo);
            }
            catch (Exception ex)
            {
                // Limpiar archivo temporal en caso de error
                if (File.Exists(tempFile))
                {
                    File.Delete(tempFile);
                }
            }
        }
        public void EliminarProducto(string archivo, string entrada, List<Producto> productos, string codigo)
        {

            CargarProductos(archivo, entrada, productos);

            string tempFile = Path.GetTempFileName();
            try
            {
                int i = productos.FindIndex(p => p.CodigoProducto.Equals(codigo, StringComparison.OrdinalIgnoreCase));
                productos.RemoveAt(i);

                using (StreamWriter fstemp = new StreamWriter(tempFile))
                {
                    // Escribir encabezado
                    fstemp.WriteLine(entrada);

                    // Escribir productos restantes
                    foreach (var producto in productos)
                    {
                        fstemp.WriteLine($"{producto.CodigoProducto};{producto.NombreProducto};{producto.CategoriaProducto};" +
                                         $"{producto.CantidadProducto};{producto.PrecioProducto}");
                    }
                }

                // Reemplazar el archivo original
                File.Delete(archivo);
                File.Move(tempFile, archivo);
            }
            catch (Exception ex)
            {
                if (File.Exists(tempFile))
                {
                    File.Delete(tempFile);
                }
                //Console.WriteLine("Error al eliminar producto: " + ex.Message);
            }
        }
    }
}
