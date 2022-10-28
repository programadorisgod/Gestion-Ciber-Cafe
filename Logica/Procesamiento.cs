using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class Procesamiento
    {
        Datos.Archivo Archivo = new Datos.Archivo();
        List<Usuario> ListaUsuario = new List<Usuario>();

        public List<Usuario> GetAll()
        {
            ListaUsuario = Archivo.GetAll();
            return ListaUsuario;
        }
        public bool PassLogin(string Username, string Password)
        {
            GetAll();
            for (int i = 0; i < ListaUsuario.Count; i++)
            {
                if (ListaUsuario[i].Username == Username && ListaUsuario[i].Password == Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
