using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Controllers
{
    public class UsuarioController
    {
        String query = $"SELECT * FROM USUARIO WHERE email = @email";
    }
}
