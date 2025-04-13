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
    public partial class G_MARCA : Form
    {
        public G_MARCA()
        {
            InitializeComponent();
        }

        private void MARCAS_Load(object sender, EventArgs e)
        {
            Admin_Marca marca = new Admin_Marca();
            try
            {
               dgvMarcas.DataSource = marca.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
