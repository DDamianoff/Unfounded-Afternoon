using Ingeniería.Backend.Interfaces;

namespace Ingeniería.Backend.Modelos;

public class Login : ILogin
{
    public string? Correo { get; set; }
    public string? Contraseña { get; set; }
}