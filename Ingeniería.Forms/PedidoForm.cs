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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        public readonly PedidoCrear PedidoCrearVista = new ();

        public readonly PedidoAdministrar PedidoAdministrarVista = new() { Dock = DockStyle.Fill };

        private void Pedido_Load(object sender, EventArgs e)
        {
            panelPedidoCrear.Controls.Add(PedidoCrearVista);
            panelPedidoAdministrar.Controls.Add(PedidoAdministrarVista);
        }
    }
}
