using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingeniería.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnFrmRegistrarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PedidoForm = new Pedido();
            PedidoForm.Closed += (_, _) => this.Show(); 
            PedidoForm.Show();
        }

        private void btnFrmRegistrarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var productoForm = new ProductoForm();
            productoForm.Closed += (_, _) => this.Show(); 
            productoForm.Show();
        }
    }
}
