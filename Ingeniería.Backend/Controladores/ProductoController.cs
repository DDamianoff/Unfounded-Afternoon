﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingeniería.Backend.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Ingeniería.Backend.Controladores
{
    public class ProductoController
    {   
        public IEnumerable<Category?> GetListCategories()
        {
            using var dbcontext = new SqLiteDbContext();

            return dbcontext.Categorías.ToList();
        }

        public IEnumerable<Brand?> GetListBrands()
        {
            using var dbcontext = new SqLiteDbContext();

            return dbcontext.Marcas.ToList();
        }

        public void SaveProductDb(Product product)
        {
            using var db = new SqLiteDbContext();

            var productToSave = new Product()
            {
                Categoría = db.Categorías.First(category => category == product.Categoría),
                Marca = db.Marcas.First(marca => marca == product.Marca),
                Descripción = product.Descripción,
                Nombre = product.Nombre,
                Precio = product.Precio,
                Stock = product.Stock,
                IsEnabled = true,
            };
            
            
            db.Productos.Add(productToSave);

            db.SaveChanges();
        }

        public Product GetFirstProduct()
        {
            using var db = new SqLiteDbContext();

            return db.Productos.First();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            using var db = new SqLiteDbContext();

            return db.Productos
                .Include(p => p.Categoría)
                .Include(p => p.Marca)
                .AsEnumerable()
                .ToList();
        }
    }
}
