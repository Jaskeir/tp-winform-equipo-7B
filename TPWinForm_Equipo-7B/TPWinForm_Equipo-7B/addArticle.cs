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
        public addArticle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addArticle_Load(object sender, EventArgs e)
        {
            Admin_Datos database = new Admin_Datos();
            Categoria categoria = new Categoria();

            try
            {
                database.setearConsulta("SELECT Id, Descripcion FROM Categorias");
                database.ejecutarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
