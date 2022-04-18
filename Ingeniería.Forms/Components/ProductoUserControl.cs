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

namespace Ingeniería.Forms.Components
{
    public partial class ProductoUserControl : UserControl
    {

        public ProductoUserControl(Product product)
        {
            InitializeComponent();
            Product = product;
            cboCategoría.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
         }

        public Product Product;

        private readonly GeneralController _controller = new GeneralController ();

        private void ProductoUserControl_Load(object sender, EventArgs e)
        {
            this.setDefaultValues();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Product.Nombre = txtNombre.Text;
            Product.Descripción = txtDescription.Text;

            Product.Precio = (double)numPrice.Value;
            Product.Stock = (int)numStock.Value;

            Product.Categoría = cboCategoría.SelectedItem as Category;
            Product.Marca = cboMarca.SelectedItem as Brand;

            _controller.GuardarCambiosProducto(Product);
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            this.setDefaultValues();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Product.IsEnabled = false;
            this.Hide();

            _controller.GuardarCambiosProducto(Product);
        }

        private void setDefaultValues()
        {
            txtDescription.Text = Product.Descripción;
            txtNombre.Text = Product.Nombre;

            numPrice.Value = (decimal)Product.Precio;
            numStock.Value = (decimal)Product.Stock;

            var brandList = _controller.GetBrands();
            var categoryList = _controller.GetCategories();

            foreach (var marca in brandList)
                if (marca != Product.Marca)
                    cboMarca.Items.Add(marca);


            foreach (var categoría in _controller.GetCategories())
                if (categoría != Product.Categoría)
                    cboCategoría.Items.Add(categoría);


            cboCategoría.Items.Insert(0, Product.Categoría);
            cboMarca.Items.Insert(0, Product.Marca);

            cboCategoría.SelectedIndex = 0;
            cboMarca.SelectedIndex = 0;
        }
    }
}
