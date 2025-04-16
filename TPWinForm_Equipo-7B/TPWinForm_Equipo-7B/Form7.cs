using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo_7B
{
    public partial class FormNuevaCategoria : Form
    {
        public FormNuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarCate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarCate_Click(object sender, EventArgs e)
        {
            Categoria cate = new Categoria();
            ManagerCategorias manager = new ManagerCategorias();

            try
            {
                cate.Nombre = txtBoxAgregarCate.Text;

                manager.agregarCategoria(cate);
                MessageBox.Show("Agregado exitosamente");

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
