using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDB;
using dominio;

namespace TPWinForm_Equipo_7B
{
    public partial class BUSQUEDA : Form
    {
        
        public BUSQUEDA()
        {
            InitializeComponent();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
       ///////

        private void BUSQUEDA_Load(object sender, EventArgs e)
        {
            
            try
            {
                ManagerCategorias admin_Categoria = new ManagerCategorias();

                cbxCategorias.DataSource = admin_Categoria.Listar();

                Admin_Marca admin_Marca = new Admin_Marca();

                cbxMarcas.DataSource = admin_Marca.Listar();

                ////
                
                articulosDatos datos = new articulosDatos();
           
                dvgArticulos.DataSource = datos.Listar();
                ///

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////
            articulosDatos datos = new articulosDatos();
            try
            {
               
                string marca = cbxMarcas.SelectedItem.ToString();
                string categoria = cbxCategorias.SelectedItem.ToString();
                string codigo = txtbCodigo.Text;
                string nombre = txtbNombre.Text;
                dvgArticulos.DataSource = datos.Busqueda(marca,categoria,codigo,nombre);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ///
        }
    }
}
