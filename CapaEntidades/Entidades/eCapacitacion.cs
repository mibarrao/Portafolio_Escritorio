using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
   public class eCapacitacion
    {
        public int idCapacitacion { get; set; }
        public int idCliente { get; set; }
        public int idProfesional { get; set; }
        public DateTime fechaCapacitacion { get; set; }
        public string observacion { get; set; }
    }
}
