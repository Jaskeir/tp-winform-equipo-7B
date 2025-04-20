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
    public partial class ventanaArticulos : Form
    {
        private List<Articulo> listaArticulos;
        
        public ventanaArticulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

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
            // abrir nueva ventana
            addArticle ventanaAddArticulo = new addArticle();

            ventanaAddArticulo.ShowDialog();
            cargarArticulos();
        }
        ///
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDA Vbuscar = new BUSQUEDA();

            Vbuscar.ShowDialog();
        }
    }
}
