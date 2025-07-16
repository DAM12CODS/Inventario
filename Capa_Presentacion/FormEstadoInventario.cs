// <copyright file="FormEstadoInventario.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Presentacion
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Capa_Entidad;
    using Datos;
    using Inventario;


    /// <summary>
    /// Representa el formulario de estado del inventario.
    /// Muestra los productos disponibles y permite volver al menú principal.
    /// </summary>
    public partial class FormEstadoInventario : Form
    {
        private List<Producto> productos = new List<Producto>();
        private string productosCSV = "productos.csv";
        private string encabezado = "Codigo;Nombre;Categoria;Cantidad;Precio";
        private bool confirmandoCierre = false;
     

        /// <summary>
        /// Initializes a new instance of the <see cref="FormEstadoInventario"/> class.
        /// </summary>
        public FormEstadoInventario()
        {
            
            this.InitializeComponent();
            this.FormClosing += FormEstadoInventario_FormClosing;

            var gestor = new GestionProducto();
            gestor.CargarProductos(this.productosCSV, this.encabezado, this.productos);

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.productos;
        }

        private void FormEstadoInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.confirmandoCierre && e.CloseReason == CloseReason.UserClosing)
            {
                this.confirmandoCierre = true;

                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea salir?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    this.confirmandoCierre = false; // permite que se pregunte de nuevo en otro intento
                }
                else
                {
                    Application.Exit(); // cierra toda la app si el usuario confirma
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormEstadoInventario_Load(object sender, EventArgs e)
        {
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuPrincipal menu = new FormMenuPrincipal();
            menu.Show();
    }
    }
}
