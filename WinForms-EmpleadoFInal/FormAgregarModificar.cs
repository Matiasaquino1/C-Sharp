using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{

    public partial class FormAgregarModificar : Form
    {
        public Empleado Empleado { get; private set; }

        public FormAgregarModificar(Empleado empleado = null)
        {
            InitializeComponent();

            if (empleado != null)
            {
                // Si el formulario se utiliza para modificar, precargar los datos del empleado
                Empleado = empleado;
                txtNombre.Text = empleado.NombreCompleto;
                txtDNI.Text = empleado.DNI;
                txtEdad.Text = empleado.Edad.ToString();
                chkCasado.Checked = empleado.Casado;
                txtSalario.Text = empleado.Salario.ToString();
            }
            else
            {
                // Si en cambio es un formulario para agregar, que empiece con el formulario vacio
                Empleado = new Empleado();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Para validar que ningun campo es null
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            try
            {
                // Actualizar los datos del empleado con los valores que se ingresaron
                Empleado.NombreCompleto = txtNombre.Text;
                Empleado.DNI = txtDNI.Text;
                Empleado.Edad = int.Parse(txtEdad.Text);
                Empleado.Casado = chkCasado.Checked;
                Empleado.Salario = double.Parse(txtSalario.Text);

                DialogResult = DialogResult.OK; // Para indicar que se guardaron todos los cambios
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el empleado: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Para indicar que no se realizo ningun cambio
            Close();
        }

        private void txtChangedNombre(object sender, EventArgs e)
        {

        }

        private void txtchangedDNI(object sender, EventArgs e)
        {

        }

        private void txtchangedEdad(object sender, EventArgs e)
        {

        }

        // Aca no pude lograr que solamente se pueda marcar un checkbox de por si esta Casado o no, al marcar los dos checkbox se guarda el Si.
        private void chkhangeSi(object sender, EventArgs e)
        {

        }

        private void chkchangeNo(object sender, EventArgs e)
        {

        }

        private void txtchangeSalario(object sender, EventArgs e)
        {

        }
    }


}
