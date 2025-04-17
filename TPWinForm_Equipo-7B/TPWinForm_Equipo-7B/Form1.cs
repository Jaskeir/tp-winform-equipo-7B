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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CATALOGO VCATALOGO = new CATALOGO();

            VCATALOGO.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            G_MARCA VMARCAS = new G_MARCA();

            VMARCAS.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vCategorias vCate = new vCategorias();

            vCate.ShowDialog();
        }
    }
}
