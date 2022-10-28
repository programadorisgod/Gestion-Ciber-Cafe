using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IserviceCliente<T>
    {
        string Guardar(T Cliente);
        string Delete (T Cliente);
        string Edit(string Cedula);
        List<T> GetAll();
        bool Exists(T Cliente);
    }
}