using Ingeniería.Backend.Interfaces;

namespace Ingeniería.Backend.Modelos;

public class User : Person, ILogin
{
    public string Correo { get; set; }
    public string Contraseña { get; set; }
}