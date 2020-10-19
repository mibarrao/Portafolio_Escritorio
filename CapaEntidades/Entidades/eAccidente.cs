using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class eAccidente
    {
        public int idAccidente { get; set; }
        public int idCliente { get; set; }
        public DateTime fechaAccidente { get; set; }
        public string descripcion { get; set; }
    }

}
