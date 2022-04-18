using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingeniería.Backend.Interfaces;
using Ingeniería.Backend.Modelos;

namespace Ingeniería.Backend.Controladores
{
    public class GeneralController
    {
        public IEnumerable<Brand?> GetBrands()
        {
            using var db = new SqLiteDbContext();

            return db.Marcas.ToList();
        }

        public IEnumerable<Category?> GetCategories()
        {
            using var db = new SqLiteDbContext();

            return db.Categorías.ToList();
        }


        public void GuardarCambiosProducto(Product product)
        {
            using var db = new SqLiteDbContext();

            var target = db.Productos.First(p => p.Id == product.Id);

            target.Nombre = product.Nombre;
            target.Descripción = product.Descripción;
            target.Categoría = db.Categorías.First(c => c == product.Categoría);
            target.Marca = db.Marcas.First(m => m == product.Marca);
            target.Precio = product.Precio;
            target.Stock = product.Stock;
            target.IsEnabled = product.IsEnabled;

            db.SaveChanges();
        }
    }
}
