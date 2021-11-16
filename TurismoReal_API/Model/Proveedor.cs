using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoReal_API.Model
{
    public class Proveedor
    {
        private int id_empresa_turismo { get; set; }
        private String rut_proveedor { get; set; }
        private String nombre_proveedor { get; set; }
        private TipoServicio objTipoServicio { get; set; }
        private EstadoProveedor objEstadoProveedor { get; set; }
        private int valor_servicio { get; set; }
        private Ciudad objCiudad { get; set; }
        private String observacion { get; set; }
    }
}
