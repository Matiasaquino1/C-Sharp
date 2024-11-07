using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace U6_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> libros = new List<string>();
        public List<string> Libros;

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //esto es para guardar todos los datos ingresados 
            string nombre = TxtNombre.Text;
            string autor = TxtAutor.Text;
            string genero = MenuGenero.SelectedItem?.ToString() ?? "Otro";
            int paginas = int.TryParse(TxtPaginas.Text, out int p) ? p : 0;
            bool importado = CheckImportado.Checked;
            decimal precio = decimal.TryParse(TxtPrecio.Text, out decimal pr) ? pr : 0;

            // para cambiar de estado si no se marca "Importado" pasa directamente a ser "Nacional"
            string estadoImportacion = importado ? "Importado" : "Nacional";

            // se crea la cadena de info del libro
            string libroInfo = $"Nombre {nombre}, Autor: {autor}, Género: {genero}, Páginas: {paginas}, Importado: {importado}, Precio: {precio:C}";


            // Agregar el libro a la lista y mostrar en el ListBox
            libros.Add(libroInfo);
            listBoxLibros.Items.Add(libroInfo);

            // Limpiar campos cada vez que se presiona el boton ingresar
            TxtNombre.Clear();
            TxtAutor.Clear();
            MenuGenero.SelectedIndex = -1;
            TxtPaginas.Clear();
            CheckImportado.Checked = false;
            TxtPrecio.Clear();

        }


        //todas las referencias
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label6_Click_1(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        
    }
}