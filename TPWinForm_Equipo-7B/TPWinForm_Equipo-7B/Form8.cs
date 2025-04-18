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
    public partial class frmArticleImages : Form
    {
        private List<Imagen> listaImagenesArticulos;
        private int indexImagen = 0;
        public frmArticleImages(List<Imagen> listImg)
        {
            listaImagenesArticulos = listImg;
            indexImagen = 0;
            InitializeComponent();
        }

        private void frmArticleImages_Load(object sender, EventArgs e)
        {
            cargarImagen();
        }

        private void cargarImagen()
        {
            try
            {
                pictureBox1.Load(listaImagenesArticulos[indexImagen].Url);
            }
            catch (Exception ex)
            {
                pictureBox1.Load("https://user-images.githubusercontent.com/47315479/81145216-7fbd8700-8f7e-11ea-9d49-bd5fb4a888f1.png");
            }
            lblInfoImgs.Text = (indexImagen + 1).ToString() + " / " + listaImagenesArticulos.Count;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indexImagen + 1 < listaImagenesArticulos.Count)
            {
                indexImagen++;
            }
            cargarImagen();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indexImagen - 1 >= 0)
            {
                indexImagen--;
            }
            
            cargarImagen();
        }
    }
}
