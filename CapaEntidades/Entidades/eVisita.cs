using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class eVisita
    {
        public int idVisita { get; set; }
        public int idCliente { get; set; }
        public int idProfesional { get; set; }
        public int idAccidente { get; set; }
        public DateTime fechaVisita { get; set; }
        public string detalle { get; set; }
        public string observacion { get; set; }
    }
}
