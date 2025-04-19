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
                dataGridViewCategorias.DataSource = managerCate.Listar();
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
    }
}
