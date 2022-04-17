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
        var dbIsGonnaBeCreated = db.Database.EnsureCreated();

        if (!dbIsGonnaBeCreated) 
            return;
            
        db.Usuarios.Add(
            new User()
            {
                Apellido = "pepe",
                Nombre = "Juan",
                Correo = "juan@mail.com",
                Contraseña = "juan123",
            });
        db.SaveChanges();
    }
}