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
    public partial class PedidoAdministrar : UserControl
    {
        public PedidoAdministrar()
        {
            InitializeComponent();
        }

        private readonly PedidoController _controller = new PedidoController();

        public List<Order> Orders;

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void PedidoAdministrar_Load(object sender, EventArgs e)
        {
            RecargarLista();
        }

        private void RecargarLista()
        {

        }
    }
}
