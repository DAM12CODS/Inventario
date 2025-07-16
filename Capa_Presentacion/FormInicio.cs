// <copyright file="FormInicio.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Presentacion
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Muestra el inicio del programa y permite salir del mismo.
    /// </summary>
    public partial class FormInicio : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormInicio"/> class.
        /// </summary>
        public FormInicio()
        {
            this.InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide(); // Oculta, no cierra

            login.FormClosed += (s, args) => this.Show(); // Vuelve a mostrar el inicio si el login se cierra
        }

        private void BtnSalirPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
