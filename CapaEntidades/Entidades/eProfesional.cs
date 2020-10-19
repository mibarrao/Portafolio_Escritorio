using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class eProfesional
    {
        public int idprofesional { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public int rut { get; set; }
        public string dvVerificador { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string profesion { get; set; }
        public string direccion { get; set; }
        public int codComuna { get; set; }
        public int codCiudad { get; set; }
        public int codRegion { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public string cargo { get; set; }

    }
}
