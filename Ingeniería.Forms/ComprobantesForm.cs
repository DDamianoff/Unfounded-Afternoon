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
using Ingeniería.Backend.Controladores;

namespace Ingeniería.Forms
{
    public partial class ComprobantesForm : Form
    {
        public ComprobantesForm(Order dataSource)
        {
            InitializeComponent();
            Order = dataSource;
        }

        public Order Order;

        private Random Randomizer = new Random();

        private void ComprobantesForm_Load(object sender, EventArgs e)
        {
            var precio = Randomizer.Next(20, 100);

            txtRazonSocial.Text = Order.Comprobante.RazónSocial;
            txtDireccion.Text = Order.Comprobante.Dirección;
            dateTimePicker1.Value = Order.Fecha;


            foreach (var producto in Order.Productos)
                lbProductos.Items.Add(producto);


            txtMoneda.Text = Order.Comprobante.Moneda.Type;

            txtSubTotal.Text = $"{precio}";
            txtDescuento.Text = "3%";
            txtTotal.Text = $"{(double)precio - (double)precio * 0.03}";
        }
    }
}
