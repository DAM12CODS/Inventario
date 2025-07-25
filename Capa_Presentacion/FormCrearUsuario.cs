using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Capa_Entidad;
namespace Capa_Presentacion
{
    public partial class FormCrearUsuario : Form
    {

        private static string rutaUsuarios = "usuarios.csv";
        private static string encabezadoUsuarios = "Nombre;Apellido;Email;Password;Rol";
        private List<Usuario> usuarios = new List<Usuario>();
        private List<String> roles = new List<string> { "Administrador", "Local" };
        private bool confirmandoCierre = false;
        GestionUsuario gestor = new GestionUsuario();

        public FormCrearUsuario()
        {
            InitializeComponent();
            this.FormClosing += FormCrearUsuario_FormClosing;
            usuarios = gestor.CargarUsuarios(rutaUsuarios, encabezadoUsuarios);
        }
        private void FormCrearUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string rol = cmbRoles.SelectedValue?.ToString().Trim();

            List<string> errores = new List<string>();
            bool hayCampoVacio = false;

            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    errores.Add("El nombre solo debe contener letras.");
                }
            }

            // Validar apellido
            if (string.IsNullOrWhiteSpace(apellido))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (!apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    errores.Add("El apellido solo debe contener letras.");
                }
            }

            // Validar email
            if (string.IsNullOrWhiteSpace(email))
            {
                hayCampoVacio = true;
            }
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    if (addr.Address != email)
                    {
                        errores.Add("El correo electrónico no tiene un formato válido.");
                    }
                }
                catch
                {
                    errores.Add("El correo electrónico no tiene un formato válido.");
                }

                if (usuarios.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                {
                    errores.Add("Ya existe un usuario registrado con ese correo electrónico.");
                }
            }

            // Validar contraseña
            if (string.IsNullOrWhiteSpace(password))
            {
                hayCampoVacio = true;
            }
            else
            {
                if (password.Length < 4)
                {
                    errores.Add("La contraseña debe tener al menos 4 caracteres.");
                }
            }

            // Validar rol
            if (string.IsNullOrWhiteSpace(rol))
            {
                hayCampoVacio = true;
            }

            // Mostrar errores
            foreach (string error in errores)
            {
                MessageBox.Show(error, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (errores.Count > 0)
            {
                return;
            }

            if (hayCampoVacio)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todo es válido, crear usuario
            Usuario usuario = new Usuario(nombre, apellido, email, password, rol);
            gestor.RegistrarUsuarios(rutaUsuarios, encabezadoUsuarios, usuario, usuarios);
            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRoles.SelectedIndex = -1;
        }


        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
            cmbRoles.DataSource = null;
            cmbRoles.DataSource = roles;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta este formulario

            FormInicio inicio = new FormInicio(); // Crea una nueva instancia del formulario de inicio
            inicio.Show(); // Muestra el formulario anterior
        }
    }
}