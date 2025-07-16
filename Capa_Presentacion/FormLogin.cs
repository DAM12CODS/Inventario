// <copyright file="FormLogin.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Capa_Presentacion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Capa_Entidad;
    using CapaDatos;

    /// <summary>
    /// Muestra el estado de inicio del programa para ingresar, además permite volver al form anterior.
    /// </summary>
    public partial class FormLogin : Form
    {
        private static string rutaUsuarios = "usuarios.csv";
        private static string encabezadoUsuarios = "Nombre;Apellido;Email;Password;Rol";
        private List<Usuario> usuarios = new List<Usuario>();
        private GestionUsuario gestor = new GestionUsuario();

        private bool cerrarSinConfirmacion = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLogin"/> class.
        /// </summary>
        public FormLogin()
        {
            this.InitializeComponent();
            this.FormClosing += FormLogin_FormClosing;

            // Carga usuarios desde el archivo CSV
            this.usuarios = gestor.CargarUsuarios(rutaUsuarios, encabezadoUsuarios);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrarSinConfirmacion)
                return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea salir del programa?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtNombre.Text.Trim();
            string contraseña = this.txtContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación contra lista de usuarios
            Usuario? user = this.usuarios.FirstOrDefault(u => !(!u.Nombre.Equals(usuario, StringComparison.OrdinalIgnoreCase)
            || u.Pass != contraseña));

            if (user != null )
            {
                FormMenuPrincipal menu = new FormMenuPrincipal();

                menu.FormClosed += (s, args) =>
                {
                    cerrarSinConfirmacion = true;
                    this.Close();
                };

                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.txtNombre.Text = string.Empty;
            this.txtContraseña.Text = string.Empty;
            this.txtNombre.Focus();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio inicio = new FormInicio();
            inicio.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnIngresar.PerformClick();
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormCrearUsuario formCrearUsuario = new FormCrearUsuario();
            formCrearUsuario.Show();
            this.Hide();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
        }

        private void Label3_Click(object sender, EventArgs e)
        {
        }
    }
}
