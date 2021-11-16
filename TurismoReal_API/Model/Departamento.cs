using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Model
{
    public class Departamento
    {
        private int idDepartamento { get; set; }
        private String nombreDepartamento { get; set; }
        private String calle { get; set; }
        private String nroCalle { get; set; }
        private String piso { get; set; }
        private int nroDepartamento { get; set; }
        private int cantHabitaciones { get; set; }
        private int cantBanios { get; set; }
        private int cantPersonas { get; set; }
        private bool aceptaMascotas { get; set; }
        private String descripcion { get; set; }
        private int id_Ciudad { get; set; }
        private int it_estado_Departamento { get; set; }
    }
}
