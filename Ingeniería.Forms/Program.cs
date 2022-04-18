using Ingeniería.Backend.Modelos;
using System;

namespace Ingeniería.Forms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        CreateDb();
        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm());
    }

    private static void CreateDb()
    {
        using var db = new SqLiteDbContext();
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
        
        #region Añadir algunos usuarios
        db.Usuarios.Add(
            new User()
            {
                Apellido = "pepe",
                Nombre = "Juan",
                Correo = "juan@mail.com",
                Contraseña = "juan123",
            });
        db.Usuarios.Add(
            new User()
            {
                Apellido = "asd",
                Nombre = "dsa",
                Correo = "aa",
                Contraseña = "aa",
            });
        db.Usuarios.Add(
            new User()
            {
                Apellido = "Hernandez",
                Nombre = "Tito",
                Correo = "tito@mail.com",
                Contraseña = "tito123",
            });
        #endregion

        #region Añadir algunas categorías

        var categorías = new List<Category>()
        {
            new() {Categoría = "Periféricos"},
            new() {Categoría = "Procesadores"},
            new() {Categoría = "Memorias RAM"},
            new() {Categoría = "Unidades de estado sólido"},
            new() {Categoría = "Placa madre"}
        };

        db.Categorías.AddRange(categorías);
        db.SaveChanges();

        #endregion

        #region Añadir algunas marcas

        var marcas = new List<Brand>()
        {
            new() {Nombre = "LogiTech"},
            new() {Nombre = "Intel"},
            new() {Nombre = "DDR Tec"},
            new() {Nombre = "DD ZD"},
            new() {Nombre = "MotherTB"}
        };

        db.Marcas.AddRange(marcas);

        #endregion
        
        #region Añadir algunos productos

        db.SaveChanges();

        List<Product> products = new List<Product>()
        {
            new ()
            {
                Nombre = "Mouse LSD",
                Categoría = db.Categorías.First(categoria => categoria.Categoría == "Periféricos"),
                Marca = db.Marcas.First(marca => marca.Nombre == "LogiTech"),
                Descripción = "Mouse gamer alta gama",
                Stock = 30,
                Precio = 49.50,
                IsEnabled = true,
            },
            new ()
            {
                Nombre = "Mouse De oficina",
                Categoría = db.Categorías.First(categoría => categoría.Categoría == "Periféricos"),
                Marca = db.Marcas.First(marca => marca.Nombre == "LogiTech"),
                Descripción = "Mouse oficina alta gama inalámbrico",
                Stock = 50,
                Precio = 39.50,
                IsEnabled = true,
            }
        };
        
        db.Productos.AddRange(products);

        db.SaveChanges();

        #endregion

        #region Añadir algunas monedas

        db.Monedas.Add(Currency.Soles);
        db.Monedas.Add(Currency.Dólares);
        db.Monedas.Add(Currency.Éuros);

        db.SaveChanges();
        #endregion

        #region Añadir algunos pedidos

        List<Order> orders = new List<Order>
        {
            new Order{
            Cliente = new Customer{Apellido = "Ramirez", Nombre = "Alberto"},
            Estado = Order.Íntegro,
            Fecha = DateTime.Now,
            Productos = new List<Product>(),
            Vendedor = db.Usuarios.First(),
            Comprobante = new Receipt()
                {
                    Dirección = "Av. Garcilaso 1250",
                    Moneda = Currency.Soles,
                    RazónSocial = "Roger Store",
                },

            },
            new Order{
            Cliente = new Customer{Apellido = "Ramón", Nombre = "Orlando"},
            Estado = Order.Íntegro,
            Fecha = DateTime.Now,
            Productos = db.Productos.ToList(),
            Vendedor = db.Usuarios.First(),
            Comprobante = new Receipt()
                {
                    Dirección = "Av. Garcilaso 1250",
                    Moneda = Currency.Soles,
                    RazónSocial = "Roger Store",
                }
            } 
        };

        foreach (var order in orders)
        {
            foreach (var product in db.Productos.AsEnumerable())
                order.Productos.Add(product);
            db.Pedidos.Add(order);
        }

        db.SaveChanges();
        #endregion

    }


    
}