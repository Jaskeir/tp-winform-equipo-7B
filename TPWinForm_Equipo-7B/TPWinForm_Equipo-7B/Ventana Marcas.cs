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
using ConexionDB;

namespace TPWinForm_Equipo_7B
{
    public partial class G_MARCA : Form
    {
        private List<Marca> marcas;
        public G_MARCA()
        {
            InitializeComponent();
        }

        private void MARCAS_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            Admin_Marca marca = new Admin_Marca();
            try
            {
                marcas = marca.Listar();
                dgvMarcas.DataSource = marcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NUEVAMARCA_Click(object sender, EventArgs e)
        {
            NUEVA_MARCA nMARCA = new NUEVA_MARCA();

            nMARCA.ShowDialog();
            cargarMarcas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            {
                Admin_Marca a_eliminar = new Admin_Marca();
                Marca seleccionada;
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Seguro que quiere eliminar la marca seleccionada?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                        a_eliminar.eliminar(seleccionada.Id);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            cargarMarcas();
        }
    }

}
