using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class eAgenda
    {
        public int idAgenda { get; set; }
        public int idProfesional { get; set; }
        public int idVisita { get; set; }
        public int idCapacitacion { get; set; }
        public DateTime agenFecha { get; set; }
        public string direccion { get; set; }
        public int idComuna { get; set; }
        public int idCiudad { get; set; }
        public int idRegion { get; set; }
        public string coordenadasX { get; set; }
        public string coordenadasY { get; set; }


    }

}
