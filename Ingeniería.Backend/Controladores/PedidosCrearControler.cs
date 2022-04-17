using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingeniería.Backend.Modelos;

namespace Ingeniería.Backend.Controladores
{
    public class PedidosCrearControler
    {
        public IQueryable<Category> GetListCategories()
        {
            using var dbcontext = new SqLiteDbContext();

            return dbcontext.Categorías;
        }
    }
}
