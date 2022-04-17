using Ingeniería.Backend.Modelos;

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
        db.SaveChanges();

        #endregion
    }
}