using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Proyecto : IComparable
    {
        private String nombre;
        private int max;
        private String descripcion;
        private List<Usuario> lista_usuarios = new List<Usuario>();

        public Proyecto(string nombre, int max, string descripcion)
        {
            this.nombre = nombre;
            this.max = max;
            this.descripcion = descripcion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Max { get => max; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<Usuario> Lista_usuarios { get => lista_usuarios; set => lista_usuarios = value; }

        public Boolean anadirUsuario(Usuario u1)
        {
            if (!lista_usuarios.Any() || (!lista_usuarios.Contains(u1) && lista_usuarios.Count() < max))
            {
                lista_usuarios.Add(u1);
                return true;
            }

            return false;
        }

        public Boolean retirarUsuario(Usuario u1)
        {
            return lista_usuarios.Remove(u1);
        }

        public Boolean eliminarIntegrantesProyecto()
        {
            if (lista_usuarios.Any())
            {
                lista_usuarios.Clear();
                return true;
            }

            return false;
        }

        public Boolean leerUsuario(Usuario u1)
        {
            return lista_usuarios.Contains(u1);
        }

        public void modificarDatos(int max, string descripcion)
        {
            this.max = max;
            this.descripcion = descripcion;
        }

        public int CompareTo(object obj)
        {
            return nombre.CompareTo(obj);
        }

        public override bool Equals(object obj)
        {
            return obj is Proyecto proyecto &&
                   nombre == proyecto.nombre;
        }

        public override int GetHashCode()
        {
            return -1597784800 + EqualityComparer<string>.Default.GetHashCode(nombre);
        }
    }
}
