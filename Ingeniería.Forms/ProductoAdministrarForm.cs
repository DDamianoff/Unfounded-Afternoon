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
using Microsoft.EntityFrameworkCore;
using Ingeniería.Forms.Components;

namespace Ingeniería.Forms
{
    public partial class AdministrarProducto : UserControl
    {
        private readonly ProductoController _controller = new();

        public AdministrarProducto()
        {
            InitializeComponent();
            pnlListContainer.AutoScroll = true;
        }

        private List<Product> Products;
        private List<ProductoUserControl> ProductoUserControls;

        private void AdministrarProducto_Load(object sender, EventArgs e)
        {
            Products = new List<Product>();
            ProductoUserControls = new List<ProductoUserControl>();

            this.RecargarLista();
        }

        public void RecargarLista()
        {
            Products.Clear();
            ProductoUserControls.Clear();
            pnlListContainer.Controls.Clear();

            Products = _controller.GetAllProducts().ToList();

            foreach (var product in Products)
                ProductoUserControls.Add(
                    new ProductoUserControl(product)
                    { 
                        Dock = DockStyle.Top 
                    });

            foreach (var productView in ProductoUserControls)
                pnlListContainer.Controls.Add(productView);

        }
    }
}
