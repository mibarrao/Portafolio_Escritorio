using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CapaDatos.Contract
{
    public interface IOperacionCrud <T>
    {
        string Insertar(T dto);
        string Actualizar(T dto);
        string Eliminar(T dto);
        List<T> Listar();
    }
}