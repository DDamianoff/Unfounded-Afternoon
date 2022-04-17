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

namespace Ingeniería.Forms
{
    public partial class RegistrarProducto : UserControl
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }

        public PedidosCrearControler controler = new PedidosCrearControler();

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            var AllCategories = controler.GetListCategories();

            foreach(var categoria in AllCategories)
                cboCategoria.Items.Add(categoria);
        }
    }
}
