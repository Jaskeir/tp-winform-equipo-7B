using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using dominio;
using ConexionDB;

namespace TPWinForm_Equipo_7B
{
    public partial class NUEVA_MARCA : Form
    {
        public NUEVA_MARCA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
            Marca marca = new Marca();
            Admin_Marca nueva = new Admin_Marca();

            try
            {
                marca.Nombre = txtNombre.Text;
              
                nueva.agregar(marca);
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
