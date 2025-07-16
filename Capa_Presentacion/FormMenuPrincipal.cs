// <copyright file="FormMenuPrincipal.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Presentacion
{
    using System;
    using System.Windows.Forms;
    using Capa_Entidad;

    /// <summary>
    /// Representa el formulario de gestion de venta.
    /// Muestra el área de selección de opciones de acciones respecto a productos o ventas.
    /// </summary>
    public partial class FormMenuPrincipal : Form
    {

        private bool confirmandoCierre = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMenuPrincipal"/> class.
        /// </summary>
        

        public FormMenuPrincipal()
        {
            this.InitializeComponent();
            this.FormClosing += FormX_FormClosing; // reemplaza "X" por el nombre del formulario
            
            
        }

        private void FormX_FormClosing(object sender, FormClosingEventArgs e)
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
                    this.confirmandoCierre = false;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void BtnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Cierra el menú principal
            FormLogin login = new FormLogin(); // Carga login desde cero
            login.Show();
        }

        private void BtnGProductos_Click(object sender, EventArgs e)
        {
            FormGestionProductos gestion = new FormGestionProductos();
            gestion.Show();
            this.Hide(); // Cierra el menú principal
        }

        private void BtnGVentas_Click(object sender, EventArgs e)
        {
            FormGestionVentas venta = new FormGestionVentas();
            venta.Show();
            this.Hide(); // Cierra el menú principal
        }

        private void BtnEInventario_Click(object sender, EventArgs e)
        {
            FormEstadoInventario estadoInventario = new FormEstadoInventario();
            estadoInventario.Show();
            this.Hide(); // Cierra el menú principal
        }
    }
}
