using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using CapaDatos.Conexion;

namespace CapaDatos.Datos
{
   public class D_Usuarios
    {
        private D_Conexion conn = new D_Conexion();

        OracleDataReader leer;

        DataTable tabla = new DataTable();
        OracleCommand comando = new OracleCommand();

        public DataTable Mostrar() {
            comando.Connection = conn.abrirConexion();
        }

    }
}
