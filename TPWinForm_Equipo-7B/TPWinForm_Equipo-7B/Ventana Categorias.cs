using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace TPWinForm_Equipo_7B
{
    public partial class vCategorias : Form
    {
        private List<Categoria> listaCategoria;
        public vCategorias()
        {
            InitializeComponent();
        }

        private void vCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            
        }

        private void btnAgregarCate_Click(object sender, EventArgs e)
        {
            FormNuevaCategoria formAgregarCate = new FormNuevaCategoria();
            formAgregarCate.Text = "Agregar Categoria";
            formAgregarCate.ShowDialog();
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            ManagerCategorias managerCate = new ManagerCategorias();
            try
            {
                listaCategoria = managerCate.Listar();
                dataGridViewCategorias.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarCate_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;

            seleccionada = (Categoria)dataGridViewCategorias.CurrentRow.DataBoundItem;

            FormNuevaCategoria modificar = new FormNuevaCategoria(seleccionada);
            modificar.ShowDialog();
            cargarCategorias();
        }

        private void btnEliminarCate_Click(object sender, EventArgs e)
        {
            ManagerCategorias manager = new ManagerCategorias();
            Categoria seleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro seleccionado?","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionada = (Categoria)dataGridViewCategorias.CurrentRow.DataBoundItem;
                    manager.eliminarCategoria(seleccionada.Id);
                    MessageBox.Show( "Registro eliminado");
                    cargarCategorias();
                } 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }



        private void BtnBuscarCate_Click(object sender, EventArgs e)
        {
            List<Categoria> ListaFiltrada;
            string filtro = txtBoxBuscarCate.Text;

            if (filtro != "")
            {
                ListaFiltrada = listaCategoria.FindAll(x => x.Nombre.ToUpper().Contains(txtBoxBuscarCate.Text.ToUpper()));
            }
            else
            {
                ListaFiltrada = listaCategoria;
            }


            dataGridViewCategorias.DataSource = null;

            dataGridViewCategorias.DataSource = ListaFiltrada;
        }
    }
}
