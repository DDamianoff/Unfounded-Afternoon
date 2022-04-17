using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingeniería.Backend.Interfaces;
using Ingeniería.Backend.Modelos;

namespace Ingeniería.Backend.Controladores
{
    public class LoginControler
    {
        public bool ValidarLogin(ILogin login)
        {
            using var dbcontext = new SqLiteDbContext();

            bool UsuarioExiste = dbcontext.Usuarios.Any(usuario => usuario.Correo == login.Correo);

            if (!UsuarioExiste)
                return false;

            var usuarioDb = dbcontext.Usuarios.First(usuario => usuario.Correo == login.Correo);
            return usuarioDb.Contraseña == login.Contraseña;
        }
    }
}
