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
    public partial class FormNuevaCategoria : Form
    {

        private Categoria categoria = null;
        public FormNuevaCategoria()
        {
            InitializeComponent();
        }

        public FormNuevaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }

        private void btnCancelarCate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarCate_Click(object sender, EventArgs e)
        {
            
            ManagerCategorias manager = new ManagerCategorias();
            Validaciones val = new Validaciones();

            try
            {
                if(categoria== null)
                {
                    categoria = new Categoria();
                }

                categoria.Nombre = txtBoxAgregarCate.Text;


                // VALIDAR IGUALES 

                List<Categoria> listaActual = manager.Listar();

                foreach (Categoria cate in listaActual)
                {
                    if(categoria.Nombre.ToUpper() == cate.Nombre.ToUpper() && categoria.Id != cate.Id)
                    {
                        MessageBox.Show("Esa categoria ya esta ingresada");
                        return;
                    }
                }

                // FIN VALIDAR IGUALES

                if (txtBoxAgregarCate.Text == "" || txtBoxAgregarCate.Text.Trim().Length < 2 || val.soloNumeros(txtBoxAgregarCate.Text.Trim()))
                {
                    MessageBox.Show("No se pudo crear la categoria. Ingrese un nombre con al menos dos caracteres, uno de los cuales debe ser una letra");
                    return;
                }

                if (categoria.Id != 0)
                {
                    manager.modificarCategoria(categoria);
                    MessageBox.Show("Modificado exitosamente");
                } else
                {
                    manager.agregarCategoria(categoria);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormNuevaCategoria_Load(object sender, EventArgs e)
        {
            try
            {

                if (categoria != null)
                {
                    txtBoxAgregarCate.Text = categoria.Nombre;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
