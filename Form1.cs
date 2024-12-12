using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox no está vacío
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                // Agregar la tarea al ListBox
                lstTareas.Items.Add(txtTarea.Text);

                // Limpiar el TextBox
                txtTarea.Clear();
            }
            else
            {
                // Mostrar un mensaje si el TextBox está vacío
                MessageBox.Show("Por favor, ingrese una tarea.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            // Verificar si hay una tarea seleccionada
            if (lstTareas.SelectedItem != null)
            {
                // Eliminar la tarea seleccionada
                lstTareas.Items.Remove(lstTareas.SelectedItem);
            }
            else
            {
                // Mostrar un mensaje si no hay una tarea seleccionada
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}