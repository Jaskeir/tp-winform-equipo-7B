﻿using System;
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
            ManagerArticulo datos = new ManagerArticulo();
            listaArticulos = datos.Listar();
            dataGridView1.DataSource = listaArticulos;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmArticleImages frmImages = new frmArticleImages();

            frmImages.Text = "Imagenes de " + listaArticulos[e.RowIndex].Nombre;
            frmImages.ShowDialog();
        }
    }
}
