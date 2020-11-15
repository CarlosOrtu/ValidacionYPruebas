using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Rol : IComparable
    {
        private String tipo_rol;
        private int ID;
        private String descripcion;
        private List<Usuario> lista_usuarios = new List<Usuario>();

        public Rol(string tipo_rol, int iD, string descripcion)
        {
            this.tipo_rol = tipo_rol;
            this.ID = iD;
            this.descripcion = descripcion;
        }

        public string Tipo_rol { get => tipo_rol; }
        public int ID1 { get => ID; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<Usuario> Lista_usuarios { get => lista_usuarios; set => lista_usuarios = value; }

        public Boolean anadirUsuario(Usuario u1)
        {
            if (!lista_usuarios.Any() || !lista_usuarios.Contains(u1))
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


        public Boolean leerUsuario(Usuario u1)
        {
            return lista_usuarios.Contains(u1);
        }

        public void modificarDatos(string tipo_rol, string descripcion)
        {
            this.tipo_rol = tipo_rol;
            this.descripcion = descripcion;
        }

        public int CompareTo(object obj)
        {
            return tipo_rol.CompareTo(obj);
        }

        public override bool Equals(object obj)
        {
            return obj is Rol rol &&
                   tipo_rol == rol.tipo_rol;
        }

        public override int GetHashCode()
        {
            return -1199168579 + EqualityComparer<string>.Default.GetHashCode(tipo_rol);
        }
    }
}
