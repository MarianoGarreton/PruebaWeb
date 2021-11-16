using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Model
{
    public class InventarioDepartamento
    {
        private int idInventario { get; set; }
        private bool estadoLuces { get; set; }
        private bool microondas { get; set; }
        private bool hervidor { get; set; }
        private bool juguera { get; set; }
        private bool wifi { get; set; }
        private bool tvCable { get; set; }
        private int cantFrazadas { get; set; }
        private int cantVasos { get; set; }
        private int cantTazas { get; set; }
        private int cantPlatos { get; set; }
        private int cantCubiertos { get; set; }
        private int id_Departamento { get; set; }
    }
}
