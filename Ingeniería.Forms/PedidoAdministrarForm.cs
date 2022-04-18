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
using Ingeniería.Forms.Components;

namespace Ingeniería.Forms
{
    public partial class PedidoAdministrar : UserControl
    {
        public PedidoAdministrar()
        {
            InitializeComponent();
        }

        private readonly PedidoController _controller = new PedidoController();

        public List<Order> Orders = new List<Order>();

        public List<PedidoUserControl> OrderViews = new List<PedidoUserControl>();

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void PedidoAdministrar_Load(object sender, EventArgs e)
        {
            RecargarLista();
        }

        public void RecargarLista()
        {
            Orders.Clear();
            OrderViews.Clear();
            pnlContainer.Controls.Clear();

            Orders = _controller.GetAllOrders().ToList();


            foreach (var order in Orders)
                OrderViews.Add(new PedidoUserControl(order) { Dock = DockStyle.Top });

            foreach (var oview in OrderViews)
                pnlContainer.Controls.Add(oview);

        }
    }
}
