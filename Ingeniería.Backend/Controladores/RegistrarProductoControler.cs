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

    }
}
