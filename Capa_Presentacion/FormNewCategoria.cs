using Datos;

using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FormNewCategoria : Form
    {
        private FormGestionProductos anterior;

        public event Action<List<string>> CategoriasActualizadas;

        private List<string> categorias = new List<string>();
        GestionProducto gestor = new GestionProducto();

        public FormNewCategoria(FormGestionProductos anterior)
        {
            InitializeComponent();
            this.anterior = anterior;
            categorias = gestor.CargarCategorias();
        }

        private void btnNewCategoria_Click(object sender, EventArgs e)
        {
            string categoria = txtNewCategoria.Text.Trim();

            // 1. Validar campo vacío
            if (string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("La categoría no puede estar vacía.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que no contenga números
            if (categoria.Any(char.IsDigit))
            {
                MessageBox.Show("La categoría no debe contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validar que no se repita (ignorando mayúsculas/minúsculas)
            if (categorias.Any(c => c.Equals(categoria, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("La categoría ya existe.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Agregar y guardar si pasa las validaciones
            categorias.Add(categoria);
            gestor.RegistrarCategoria(categoria);
            CategoriasActualizadas?.Invoke(categorias); // notifica al form anterior
            txtNewCategoria.Clear();

            MessageBox.Show("Categoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void txtNewCategoria_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnNewCategoria.PerformClick();
                e.Handled = true;
            }
        }
    }
}