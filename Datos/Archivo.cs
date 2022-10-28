using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Archivo
    {
        protected string ruta;
        public Archivo()
        {
            ruta = "Usuarios.txt";
        }
        public Archivo(string filename)
        {
            ruta = filename;
        }
        public List<Usuario> GetAll()
        {
            bool seguir = true;

            List<Entidades.Usuario> ListaUsuarios = new List<Entidades.Usuario>();
            do
            {
                try
                {
                    StreamReader sr = new StreamReader(ruta);

                    while (!sr.EndOfStream)
                    {
                        ListaUsuarios.Add(Mapear(sr.ReadLine()));

                    }
                    sr.Close();
                    seguir = true;
                }
                catch (Exception)
                {
                    CrearArchivo();
                    seguir = false;
                }

            } while (seguir == false);

            return ListaUsuarios;
        }
        Entidades.Usuario Mapear(string linea)
        {
            var usuario = new Entidades.Usuario();
            usuario.Username = linea.Split(';')[0];
            usuario.Password = linea.Split(';')[1];
            return usuario;
        }
        public string CrearArchivo()
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.Close();
            return "";
        }
    }
}
