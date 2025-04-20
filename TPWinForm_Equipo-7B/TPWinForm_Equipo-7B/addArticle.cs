using ConexionDB;
using dominio;
using System;
using System.Collections;
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
            articulosDatos manager = new articulosDatos();
            Validaciones val = new Validaciones();
            Articulo articulo = new Articulo();
            string nombre = txtBoxNombreArticulo.Text;
            string descripcion = txtBoxDescripcionArticulo.Text;
            Marca marca = (Marca)comboBoxMarca.SelectedItem;
            Categoria categoria = (Categoria)comboBoxCategoria.SelectedItem;
            string precio = txtBoxPrecioArticulo.Text;

            if (nombre == "")
            {
                MessageBox.Show("Debes indicar un nombre para el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (precio == "")
            {
                MessageBox.Show("Debes indicar un precio para el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!val.soloNumeros(precio))
            {
                MessageBox.Show("El precio no puede contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (decimal.Parse(precio) < 0)
            {
                MessageBox.Show("Debes ingresar un valor válido de precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            articulo.Nombre = nombre;
            articulo.Descripcion = descripcion;
            articulo.Marca = marca;
            articulo.Categoria = categoria;
            articulo.Precio = decimal.Parse(precio);
            articulo.Imagenes = imagenes;
            articulo.Codigo = generateCode(marca.Nombre);

            manager.addArticle(articulo);

            Close();
        }

        private string generateCode(string marca)
        {
            string inicialMarca = marca.Substring(0, 1).ToUpper();
            int codigoMarca = 1;
            List<int> codigosExistentes = new List<int>();

            Admin_Datos database = new Admin_Datos();
            database.setearConsulta("SELECT Codigo FROM Articulos WHERE Codigo LIKE @codigo");
            database.setearParametro("@codigo", inicialMarca + "%");
            database.ejecutarLectura();

            while (database.Lector.Read())
            {
                string codigo = (string)database.Lector["Codigo"];
                codigo = codigo.Substring(1);

                codigosExistentes.Add(int.Parse(codigo));
            }
            
            while (codigosExistentes.Contains(codigoMarca))
            {
                codigoMarca++;
            }

            return inicialMarca + codigoMarca;
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
            foreach (Imagen img in imagenes)
            {
                if (img.Url == selectedURL)
                {
                    imagenes.Remove(img);
                    break;
                }
            }
        }
    }
}
