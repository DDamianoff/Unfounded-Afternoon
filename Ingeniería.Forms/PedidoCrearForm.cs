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
    public partial class PedidoCrear : UserControl
    {
        public PedidoCrear()
        {
            InitializeComponent();
        }

        private readonly PedidoController _controller = new PedidoController();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var productList = new List<Product>();

            foreach (Product product in lbxProductos.Items)
                productList.Add(product);


            var pedido = new Order()
            {
                Cliente = new Customer()
                {
                    Apellido = txtApellido.Text,
                    Nombre = txtNombre.Text
                },

                Productos = productList,
                Comprobante = new Receipt()
                {
                    Dirección = "Av. Garcilaso 1250",
                    Moneda = Currency.Soles,
                    RazónSocial = "Roger Store",
                },
                Estado = cboEstado.SelectedItem as string,
                Vendedor = cboAuxVenta.SelectedItem as User,
                Fecha = dateTimePicker1.Value

            };

            _controller.AddOrder(pedido);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            lbxProductos.Items.Add(cboNombreProducto.SelectedItem);
        }

        private void PedidoCrear_Load(object sender, EventArgs e)
        {
            var stateList = new List<string>()
            {
                Order.Íntegro,
                Order.Cancelado
            };

            foreach (var user in _controller.AllUsers())
                cboAuxVenta.Items.Add(user);

            foreach (var state in stateList)
                cboEstado.Items.Add(state);

            foreach (var product in _controller.GetAllProducts())
                cboNombreProducto.Items.Add(product);
        }
    }
}
