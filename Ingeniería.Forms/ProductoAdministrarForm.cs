using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingeniería.Backend.Controladores;
using Ingeniería.Backend.Modelos;

namespace Ingeniería.Forms
{
    public partial class AdministrarProducto : UserControl
    {
        private readonly ProductoController _controller = new();
        public AdministrarProducto()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarProducto_Load(object sender, EventArgs e)
        {
            var products = _controller.GetAllProducts();
            dataGridView1.DataSource = products;
        }
    }
}
