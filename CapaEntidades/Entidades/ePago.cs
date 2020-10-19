using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class ePago
    {
        public int idPago { get; set; }
        public int idCliente { get; set; }
        public int idContrato { get; set; }
        public DateTime fechaPago { get; set; }
        public int valorPago { get; set; }
    }
}
