using Capa_Entidad;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Math;
using SpreadsheetLight;
using System.Data;
using System.Security.Principal;
namespace CapaDatos
{

    public class VentaDatos
    {
        private readonly string rutaArchivo = "ventas.txt";

        public void GuardarVentasEnTxt(List<Venta> ventas)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                foreach (var venta in ventas)
                {
                    // Línea principal de la venta
                    writer.WriteLine($"VENTA|{venta.IdVenta}|{venta.FechaVenta:yyyy-MM-dd}");

                    // Detalles de la venta
                    foreach (var detalle in venta.Detalles)
                    {
                        writer.WriteLine($"DETALLE|{detalle.Producto.CodigoProducto}|{detalle.Cantidad}|{detalle.PrecioUnitario}");
                    }
                }
            }
        }

        public List<Venta> CargarVentasDesdeTxt(Func<string, IProducto> buscarProducto)
        {
            var ventas = new List<Venta>();
            Venta ventaActual = null;

            foreach (var linea in File.ReadAllLines(rutaArchivo))
            {
                var partes = linea.Split('|');
                if (partes[0] == "VENTA")
                {
                    string id = partes[1];
                    DateTime fecha = DateTime.Parse(partes[2]);
                    ventaActual = new Venta(id, fecha);
                    ventas.Add(ventaActual);
                }
                else if (partes[0] == "DETALLE" && ventaActual != null)
                {
                    string codigoProducto = partes[1];
                    int cantidad = int.Parse(partes[2]);
                    IProducto producto = buscarProducto(codigoProducto); // Método externo para encontrar producto
                    var detalle = new DetalleVenta(producto, cantidad);
                    ventaActual.AgregarDetalle(detalle);
                }
            }

            return ventas;
        }
    }


  
}
class Program
{
    static void Main(string[] args)
    {
        string pathfile = AppDomain.CurrentDomain.BaseDirectory + "miArchivo";
        SLDocument oSLDocument = new SLDocument();
        DataTable table = new DataTable();
        //Columnas 
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Nombre", typeof(string));
        table.Columns.Add("Precio", typeof(double));

        //Registro 
        table.Rows.Add(1, "Paleta", 5.50);
        table.Rows.Add(2, "Papas", 12);
        table.Rows.Add(3, "Galletas", 10); 

        oSLDocument.ImportDataTable(1,1,table, true);
        oSLDocument.SaveAs(pathfile);

        //Leer archivo exel 
        int indice = 1; 
        SLDocument miArchivo= new SLDocument(pathfile);

        while (!string.IsNullOrEmpty(miArchivo.GetCellValueAsString(indice, 1))) 
        {
            if(indice == 1)
            {
                string enc1 = miArchivo.GetCellValueAsString(indice, 1);
                string enc2 = miArchivo.GetCellValueAsString(indice, 2);
                string enc3 = miArchivo.GetCellValueAsString(indice, 3);
                Console.WriteLine(enc1, enc2, enc3);
            }
            else
            {
                int id = miArchivo.GetCellValueAsInt32(indice, 1);
                string nombre = miArchivo.GetCellValueAsString(indice, 2);
                double precio = miArchivo.GetCellValueAsDouble(indice, 3);
                Console.WriteLine(id + "   " + nombre + "   " + precio);
            }

                indice++;
        }
    }
}