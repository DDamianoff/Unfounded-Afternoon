using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingeniería.Backend.Modelos;

namespace Ingeniería.Forms.Components
{
    public partial class PedidoUserControl : UserControl
    {
        public PedidoUserControl(Order order)
        {
            InitializeComponent();
            OrderData = order;
        }

        public Order OrderData;

        private void PedidoUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            lblTitulo.Text = $"{OrderData.Id}: {OrderData.Cliente.Nombre} {OrderData.Cliente.Apellido}";
            lblDate.Text = $"{OrderData.Fecha}";
            lblEstado.Text = $"Estado: {OrderData.Estado}";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblEstado.Text = $"Estado: {cboStatus.SelectedItem}";
        }

        private void btnVerComprobante_Click(object sender, EventArgs e)
        {
            var comprobante = new ComprobantesForm(OrderData);
            comprobante.Show();
        }
    }
}
