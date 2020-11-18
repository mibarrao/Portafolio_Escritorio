using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.Conexion;
using CapaDatos.Datos;
using CapaEntidades;
using CapaEntidades.Entidades;


namespace CapaNegocio
{
    public class nUsuario
    {
        
        D_Usuarios objd = new D_Usuarios();


        public DataTable N_Usuario(eUsuario obje)
        {
            return objd.D_usuario(obje);
        }


    }
}
