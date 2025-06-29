using Inventario;

namespace Datos
{
    public class GestionProducto
    {
        public void CargarProductos(string archivo, string entrada, List<Producto> productos)
        {

            try
            {
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
                        if (items.Length >= 6)
                        {
                            bool disponible;
                            int cantidad;
                            double precio;

                            // Intenta convertir los valores (maneja posibles errores de formato)
                            bool.TryParse(items[3], out disponible);
                            int.TryParse(items[4], out cantidad);
                            double.TryParse(items[5], out precio);
                            var producto = new Producto(
                                items[0],
                                items[1],
                                items[2],
                                disponible,
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
            string nombre, string categoria, bool estado, int cantidad, double precio)
        {
            var verificar = new GestionDatos();
            verificar.VerificarArchivo(archivo, entrada);
            CargarProductos(archivo, entrada, productos);
            try
            {
                using (StreamWriter datos = File.AppendText(archivo))
                {
                    Producto nuevoProducto = new Producto(codigo, nombre, categoria, estado, cantidad, precio);
                    productos.Add(nuevoProducto);
                    // Escribir en el archivo
                    datos.WriteLine($"\n{codigo};{nombre};{categoria};{estado};{cantidad};{precio}");
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ActualizarProducto(string archivo, string entrada, List<Producto> productos, string codigo,
            string nombre, string categoria, bool estado, int cantidad, double precio)
        {
            CargarProductos(archivo, entrada, productos);
            string tempFile = Path.GetTempFileName();
            try
            {
                Producto productoEncontrado = productos.FirstOrDefault(p => p.CodigoProducto == codigo);

                productoEncontrado.NombreProducto = nombre;
                productoEncontrado.CategoriaProducto = categoria;
                productoEncontrado.EstadoProducto = estado;
                productoEncontrado.CantidadProducto = cantidad;
                productoEncontrado.PrecioProducto = precio;

                using (StreamWriter fstemp = new StreamWriter(tempFile))
                {
                    // Escribir encabezado
                    fstemp.WriteLine(entrada);

                    // Escribir todos los productos
                    foreach (var producto in productos)
                    {
                        fstemp.WriteLine($"{codigo};{nombre};{categoria};{estado};{cantidad};{precio}");
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
                                         $"{producto.EstadoProducto};{producto.CantidadProducto};{producto.PrecioProducto}");
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
