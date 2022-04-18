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

namespace Ingeniería.Forms
{
    public partial class AdministrarProducto : UserControl
    {
        private readonly ProductoController _controller = new();

        public SqLiteDbContext db;

        public AdministrarProducto()
        {
            InitializeComponent();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count < 1)
                return;

            var test = dataGridView1.SelectedRows.Cast<Product>();
            
            // foreach (var row in dataGridView1.SelectedRows.Cast<DataGridViewRow>())
            // {
            //     row.Cells
            // }

            var result = db.SaveChanges();

            if (result > 0)
                MessageBox.Show($"Se eliminaron {result} productos exitosamente");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var result = db.SaveChanges();

            if (result > 0)
                MessageBox.Show($"Se modificaron {result} productos exitosamente");
        }


        private void AdministrarProducto_Load(object sender, EventArgs e)
        {
            db = new SqLiteDbContext();
            dataGridView1.DataSource = db.Productos.Include(producto => producto.Categoría)
                .Include(producto => producto.Marca)
                .Where(p => p.IsEnabled)
                .ToList();
        }
    }
}
