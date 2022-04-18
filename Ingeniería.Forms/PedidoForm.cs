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

        public readonly PedidoCrear PedidoCrearVista = new () { Dock = DockStyle.Fill };

        public readonly PedidoAdministrar PedidoAdministrarVista = new() { Dock = DockStyle.Fill };

        private void Pedido_Load(object sender, EventArgs e)
        {
            panel3.Controls.Add(PedidoCrearVista);
            panel2.Controls.Add(PedidoAdministrarVista);
        }
    }
}
