using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingeniería.Backend.Modelos;

namespace Ingeniería.Backend.Controladores
{
    public class RegistrarProductoControler
    {   
        public IEnumerable<Category> GetListCategories()
        {
            using var dbcontext = new SqLiteDbContext();

            return dbcontext.Categorías.ToList();
        }

        public IEnumerable<Brand> GetListBrands()
        {
            using var dbcontext = new SqLiteDbContext();

            return dbcontext.Marcas.ToList();
        }

        public void SaveProductDb(Product product)
        {
            using var db = new SqLiteDbContext();

            var ProductToSave = new Product()
            {
                Categoría = db.Categorías.First(category => category == product.Categoría),
                Marca = db.Marcas.First(marca => marca == product.Marca),
                Descripción = product.Descripción,
                Nombre = product.Nombre,
                Precio = product.Precio,
                Stock = product.Stock
            };
            
            
            db.Productos.Add(ProductToSave);

            db.SaveChanges();
        }

        public Product GetFirstProduct()
        {
            using var db = new SqLiteDbContext();

            return db.Productos.First();
        }
    }
}
