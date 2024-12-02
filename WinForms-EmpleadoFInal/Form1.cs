using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private EmpleadoRepository empleadoRepository = new EmpleadoRepository();

        public Form1()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            List<Empleado> empleados = empleadoRepository.ObtenerEmpleados();
            dgvEmpleados.DataSource = empleados; //dvgEmpleados es el DataGridView
            dgvEmpleados.Columns["Id"].Visible = false; // Oculta la columna Id
            dgvEmpleados.ReadOnly = true; // Hace la función de no poder editar
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarModificar formAgregar = new FormAgregarModificar();
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                empleadoRepository.AgregarEmpleado(formAgregar.Empleado);
                CargarEmpleados();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                Empleado empleado = (Empleado)dgvEmpleados.SelectedRows[0].DataBoundItem;
                FormAgregarModificar formModificar = new FormAgregarModificar(empleado);
                if (formModificar.ShowDialog() == DialogResult.OK)
                {
                    empleadoRepository.ModificarEmpleado(formModificar.Empleado);
                    CargarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int id = ((Empleado)dgvEmpleados.SelectedRows[0].DataBoundItem).Id;
                empleadoRepository.EliminarEmpleado(id);
                CargarEmpleados();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)//Filtrar empleados
        {
            string filtro = txtFiltro.Text.ToLower();
            List<Empleado> empleados = empleadoRepository.ObtenerEmpleados();
            dgvEmpleados.DataSource = empleados.FindAll(emp => emp.NombreCompleto.ToLower().Contains(filtro));
        }


    }

}
