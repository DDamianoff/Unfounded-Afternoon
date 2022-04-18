﻿using System;
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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }


        public ProductoRegistrar ProductoRegistrarVista= new ProductoRegistrar();

        public AdministrarProducto administrarProductoVista = new AdministrarProducto();

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            panelRegistrarProducto.Controls.Add(ProductoRegistrarVista);
            panelAdministrarProducto.Controls.Add(administrarProductoVista);
        }
    }
}
