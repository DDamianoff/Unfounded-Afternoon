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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }


        public ProductoRegistrar ProductoRegistrarVista= new ()
        { Dock = DockStyle.Fill };

        public AdministrarProducto AdministrarProductoVista = new ()
        { Dock = DockStyle.Fill };

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            panelRegistrarProducto.Controls.Add(ProductoRegistrarVista);
            panelAdministrarProducto.Controls.Add(AdministrarProductoVista);
        }

        private void ProductoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            AdministrarProductoVista.RecargarLista();
        }
    }
}
