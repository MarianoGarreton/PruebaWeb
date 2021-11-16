using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Model
{
    public class CheckOut
    {
        private int id_checkOut { get; set; }
        private int id_Reserva { get; set; }
        private char Multa { get; set; }
        private String observaciones { get; set; }
        private String fecha_CheckOut { get; set; }
    }
}
