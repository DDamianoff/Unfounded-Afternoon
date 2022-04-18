using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingeniería.Backend.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Ingeniería.Backend.Controladores
{
    public class PedidoController
    {
        public IEnumerable<User> AllUsers()
        {
            using var dbcontext = new SqLiteDbContext();
            return dbcontext.Usuarios.ToList();
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

        public void AddOrder(Order pedido)
        {
            using var db = new SqLiteDbContext();

            var pedidoToAdd = new Order();

            pedidoToAdd.Fecha = pedido.Fecha;
            pedidoToAdd.Vendedor = db.Usuarios.First(pe => pe.Id == pedido.Vendedor.Id);
            pedidoToAdd.Estado = pedido.Estado;
            pedidoToAdd.Cliente = pedido.Cliente;
            pedidoToAdd.Productos = new List<Product>(); 

            foreach (var producto in pedido.Productos)
                pedidoToAdd.Productos.Add(db.Productos.First(p => p.Id == producto.Id));


            pedidoToAdd.Comprobante = new Receipt()
            {
                Dirección = pedido.Comprobante.Dirección,
                Moneda = db.Monedas.First(m => m.Type == pedido.Comprobante.Moneda.Type),
                RazónSocial = pedido.Comprobante.RazónSocial
            };
            db.Pedidos.Add(pedidoToAdd);

            db.SaveChanges();
        }
    
        public ICollection<Order> GetAllOrders()
        {
            using var db = new SqLiteDbContext();

            return db.Pedidos
                .Include(o => o.Cliente)
                .Include(o => o.Productos)
                .Include(o => o.Comprobante)
                .Include(o => o.Comprobante.Moneda)
                .Include(o => o.Vendedor)
                .AsEnumerable()
                .ToList();
        }
    }
}
