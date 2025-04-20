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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPWinForm_Equipo_7B
{
    public partial class ventanaArticulos : Form
    {
        private List<Articulo> listaArticulos;
        
        public ventanaArticulos()
        {
            InitializeComponent();
        }

        private void CATALOGO_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void cargarArticulos()
        {
            articulosDatos datos = new articulosDatos();
            listaArticulos = datos.Listar();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaArticulos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            frmArticleImages frmImages = new frmArticleImages(listaArticulos[e.RowIndex].Imagenes);

            frmImages.Text = "Imagenes de " + listaArticulos[e.RowIndex].Nombre;
            frmImages.ShowDialog();
        }

        private void btnAddArticulo_Click(object sender, EventArgs e)
        {
            frmManagerArticulo ventanaAddArticulo = new frmManagerArticulo();

            ventanaAddArticulo.ShowDialog();
            cargarArticulos();
        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            frmManagerArticulo ventanaAddArticulo = new frmManagerArticulo((Articulo)dataGridView1.CurrentRow.DataBoundItem);

            ventanaAddArticulo.ShowDialog();
            cargarArticulos();
        }
        ///
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDA Vbuscar = new BUSQUEDA();

            Vbuscar.ShowDialog();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            articulosDatos articulosDatos = new articulosDatos();
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo?", "Eliminar Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
                articulosDatos.removeArticle((Articulo)dataGridView1.CurrentRow.DataBoundItem);

            cargarArticulos();
        }
    }
}
