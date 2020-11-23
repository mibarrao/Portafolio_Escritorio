using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class eUsuario
    {

        public int idUsuario { get; set; }
        public int idTipoUsuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int activo{ get; set; }
        public int idcliente { get; set; }
        public int idprofesional { get; set; }



    }
}
