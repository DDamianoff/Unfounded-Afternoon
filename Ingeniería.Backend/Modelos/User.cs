using Ingeniería.Backend.Interfaces;

namespace Ingeniería.Backend.Modelos;

public class User : ILogin
{
    public int Id
    {
        get;
        set;
    }

    public string Nombre
    {
        get;
        set;
    }

    public string Apellido
    {
        get;
        set;
    }
    
    public string Correo { get; set; }
    public string Contraseña { get; set; }
}