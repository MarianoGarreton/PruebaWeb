using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Model
{
    public class Reserva
    {
        private int cod_reserva { get; set; }
        private int id_departamento { get; set; }
        private int id_Usuario { get; set; }
        private String fecha_inicio { get; set; }
        private String fecha_fin { get; set; }
        private int total_reserva { get; set; }
        private char pago_reserva { get; set; }
        private int monto_reserva { get; set; }
        private int monto_pendiente { get; set; }
        private int total_multa { get; set; }
        private int id_reserva { get; set; }
        private String observacion { get; set; }
    }
}
