using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Model
{
    public class Usuario
    {
        private int RutUsuario { get; set; }
        private Char Dv { get; set; }
        private String Nombre { get; set; }
        private String ApellidoPaterno { get; set; }
        private String ApellidoMaterno { get; set; }
        private String NroTelefono { get; set; }
        private String Email { get; set; }
        private int CodCiudad { get; set; }
        private Char Frecuencia { get; set; }
        private int IdTipoUsuario { get; set; }
        private int IdEstadoUsuario { get; set; }
        private String Contrasenia { get; set; }

    }
}
