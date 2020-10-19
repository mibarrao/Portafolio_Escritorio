using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class eContrato
    {
        public int idContrato { get; set; }
        public string detalle { get; set; }
        public int idCliente { get; set; }
        public DateTime fechaContrato { get; set; }
        public int idPlan{ get; set; }
    }
}
