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
            var fP = new Pedido();
            fP.Show();
        }

        private void btnFrmRegistrarProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fRP = new Pedido();
            fRP.Show();
        }
    }
}
