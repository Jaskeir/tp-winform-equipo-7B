using ConexionDB;
using dominio;
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
    public partial class addArticle : Form
    {
        private List<Marca> marcas;
        private List<Categoria> categorias;
        public addArticle()
        {
            InitializeComponent();
        }

        private void loadCategoriasOnComboBox()
        {
            ManagerCategorias admin_Categoria = new ManagerCategorias();
            categorias = admin_Categoria.Listar();

            comboBoxCategoria.DataSource = categorias;
        }

        private void loadMarcasOnComboBox()
        {
            Admin_Marca admin_Marca = new Admin_Marca();
            marcas = admin_Marca.Listar();

            comboBoxMarca.DataSource = marcas;
        }

        private void addArticle_Load(object sender, EventArgs e)
        {
            loadCategoriasOnComboBox();
            loadMarcasOnComboBox();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.Nombre = txtBoxNombreArticulo.Text;
            articulo.Descripcion = txtBoxDescripcionArticulo.Text;
            articulo.Marca = (Marca)comboBoxMarca.SelectedItem;
            articulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
            articulo.Precio = 0;

        }
        private void lblCategoriaArticulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminMarcas_Click(object sender, EventArgs e)
        {
            G_MARCA VMARCAS = new G_MARCA();
            VMARCAS.ShowDialog();
            loadMarcasOnComboBox();
        }

        private void btnAdminCategorias_Click(object sender, EventArgs e)
        {
            vCategorias ventanaCate = new vCategorias();
            ventanaCate.ShowDialog();
            loadCategoriasOnComboBox();
        }
    }
}
