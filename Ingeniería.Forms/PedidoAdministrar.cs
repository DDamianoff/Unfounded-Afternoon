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
    public partial class PedidoAdministrar : UserControl
    {
        public PedidoAdministrar()
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

        private void btnVerDetallePedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comprobantes FrmCom = new Comprobantes();
            FrmCom.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
