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
using System.Text.RegularExpressions;
namespace Capa_Presentacion
{
    public partial class FormCrearUsuario : Form
    {

        private static string rutaUsuarios = "usuarios.csv";
        private FormInicio formAnterior;

        private static string encabezadoUsuarios = "Nombre;Apellido;Email;Password;Rol";
        private List<Usuario> usuarios = new List<Usuario>();
        private List<String> roles = new List<string> { "Administrador", "Local" };
        GestionUsuario gestor = new GestionUsuario();
        public FormCrearUsuario()
        {
            InitializeComponent();
            usuarios = gestor.CargarUsuarios(rutaUsuarios, encabezadoUsuarios);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario(
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text.Trim(),
                    cmbRoles.SelectedValue?.ToString().Trim()
                );

                gestor.RegistrarUsuarios(rutaUsuarios, encabezadoUsuarios, usuario, usuarios);

                MessageBox.Show("Cuenta creada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia los campos después del registro
                txtNombre.Clear();
                txtApellido.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                cmbRoles.SelectedIndex = 0;
            }
        }

        private bool ValidarCampos()
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string rol = cmbRoles.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) ||string.IsNullOrWhiteSpace(apellido) ||string.IsNullOrWhiteSpace(email) ||string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el nombre solo tenga letras
            if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el apellido solo tenga letras
            if (!Regex.IsMatch(apellido, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("El apellido solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar formato de correo
            if (!Regex.IsMatch(email, @"^[\w\.-]+@(?:gmail\.com|hotmail\.com|outlook\.com|yahoo\.com)$"))
            {
                MessageBox.Show("Ingrese un correo válido (@gmail.com, @hotmail.com, @outlook.com, @yahoo.com).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
            cmbRoles.DataSource = null;
            cmbRoles.DataSource = roles;

            // Opcional: enmascarar contraseña con asteriscos
            txtPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario
             formAnterior.Show(); // Muestra el menú principal nuevamente
        }
    }
}
