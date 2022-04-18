﻿using System;
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
    public partial class ProductoRegistrar : UserControl
    {
        public ProductoRegistrar()
        {
            InitializeComponent();
        }

        private readonly ProductoController _controller = new ();

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            var AllCategories = _controller.GetListCategories();

            foreach(var categoria in AllCategories)
                cboCategoria.Items.Add(categoria);

            var AllBrands = _controller.GetListBrands();

            foreach(var marca in AllBrands)
                cboMarca.Items.Add(marca);
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Categoría = (Category)cboCategoria.SelectedItem,
                Marca = (Brand)cboMarca.SelectedItem,
                Nombre = txtNombre.Text,
                Descripción = txtDescripcionProducto.Text,
                Precio = (double)nupPrecio.Value,
                Stock = (int)nupStock.Value
            };

            _controller.SaveProductDb(product);
        }
    }
}
