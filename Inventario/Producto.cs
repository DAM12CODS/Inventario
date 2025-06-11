namespace Inventario
{
    public class Producto
    {
        private string codigo_Producto;
        private string nombre_Producto;
        private string categoria_Producto;
        private string estado_Producto; //PROBABLEMENTE SE ELIMINE...
        private int cantida_Producto;
        private double precio_Producto;

        private string fecha_Registro;
        private string fecha_Vencimiento;

        
        public Producto(string Codigo_Producto, string Nombre_Producto, string Categoria_Producto, string Estado_Producto, int Cantida_Producto, double Precio_Producto, string Fecha_Registro, string Fecha_Vencimiento)
        {
            //Decidir si los parametros se inician con mayúscula...

            this.codigo_Producto = Codigo_Producto;
            this.nombre_Producto = Nombre_Producto;
            this.categoria_Producto = Categoria_Producto;
            this.estado_Producto = Estado_Producto;
            this.cantida_Producto = Cantida_Producto;
            this.precio_Producto = Precio_Producto;

            this.fecha_Registro = Fecha_Registro;
        }

        public string Codigo_Producto
        {
            get { return this.codigo_Producto; }
            set { codigo_Producto = value; }
        }

        public string Nombre_Producto
        {
            get { return this.nombre_Producto; }
            set { codigo_Producto = value; }
        }

        public string Categoria_Producto
        {
            get { return this.categoria_Producto; }
            set { categoria_Producto = value; }
        }

        public string Estado_Producto
        {
            get { return this.estado_Producto; }
            set { estado_Producto = value; }
        }

        public int Cantida_Producto
        {
            get { return this.cantida_Producto; }
            set { cantida_Producto = value; }
        }

        public double Precio_Producto
        {
            get { return this.precio_Producto; }
            set { precio_Producto = value; }
        }

        public string Fecha_Registro
        {
            get { return this.fecha_Registro; }
            set { fecha_Registro = value; }
        }

        public string Fecha_Vencimiento
        {
            get { return this.fecha_Vencimiento; }
            set { fecha_Vencimiento = value; }
        }


    }
}
