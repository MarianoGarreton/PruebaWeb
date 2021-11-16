using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Model
{
    public class CheckIn
    {
        private int id_checkIn { get; set; }
        private int id_Reserva  { get; set; }
        private String Entrega_Regalo { get; set; }
        private String Estado_Pago { get; set; }
        private String Observaciones_Usuario { get; set; }
        private String Fecha_CheckIn { get; set; }

    }
}
