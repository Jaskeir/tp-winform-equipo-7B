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
        private List<Imagen> imagenes = new List<Imagen>();
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
            articulo.Precio = decimal.Parse(txtBoxPrecioArticulo.Text);
            articulo.Imagenes = imagenes;
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

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            loadPreviewImage(txtBoxURL.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printImagesToListBox()
        {
            listBoxImgURL.Items.Clear();
            foreach (Imagen img in imagenes)
            {
                listBoxImgURL.Items.Add(img.Url);
            }
        }

        private bool isUrlInList(Imagen img)
        {
            foreach (Imagen value in imagenes)
            {
                if (value.Url == img.Url)
                {
                    return true;
                }
            }
            return false;
        }

        private void loadPreviewImage(string URLImage)
        {
            Validaciones val = new Validaciones();
            if (!val.link(URLImage))
            {
                MessageBox.Show("Debes indicar una URL Válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                pictureBoxArticulo.Load(URLImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addImg_Click(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            string stringURL = txtBoxURL.Text;

            if (!val.link(stringURL))
            {
                MessageBox.Show("Debes indicar una URL Válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Imagen img = new Imagen(stringURL);

            if (isUrlInList(img)) {
                MessageBox.Show("Esta imágen ya está añadida para el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            imagenes.Add(img);
            printImagesToListBox();
        }

        private void listBoxImgURL_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxImgURL.SelectedItem == null)
            {
                loadPreviewImage("https://user-images.githubusercontent.com/47315479/81145216-7fbd8700-8f7e-11ea-9d49-bd5fb4a888f1.png");
                return;
            }
            loadPreviewImage(listBoxImgURL.SelectedItem.ToString());
        }

        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            if (listBoxImgURL.SelectedItem == null)
            {
                return;
            }
            string selectedURL = listBoxImgURL.SelectedItem.ToString();
            listBoxImgURL.Items.Remove(selectedURL);
        }
    }
}
