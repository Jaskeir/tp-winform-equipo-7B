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
    public partial class vCategorias : Form
    {
        public vCategorias()
        {
            InitializeComponent();
        }

        private void vCategorias_Load(object sender, EventArgs e)
        {
            ManagerCategorias managerCate = new ManagerCategorias();

            dataGridViewCategorias.DataSource = managerCate.Listar();
        }
    }
}
