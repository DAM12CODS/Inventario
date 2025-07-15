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
        GestionUsuario gestor = new GestionUsuario();
        public FormCrearUsuario()
        {
            InitializeComponent();
            usuarios = gestor.CargarUsuarios(rutaUsuarios, encabezadoUsuarios);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPassword.Text.Trim(),
                cmbRoles.SelectedValue?.ToString().Trim()
                );
            gestor.RegistrarUsuarios(rutaUsuarios, encabezadoUsuarios, usuario, usuarios);
        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {
            cmbRoles.DataSource = null;
            cmbRoles.DataSource = roles;
        }
    }
}
