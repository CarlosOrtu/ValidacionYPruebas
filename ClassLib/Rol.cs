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
        private String ID;
        private String descripcion;
        List<Usuario> lista_usuarios;

        public Rol(string tipo_rol, string iD)
        {
            this.tipo_rol = tipo_rol;
            this.ID = iD;
        }

        public string Tipo_rol { get => tipo_rol; }
        public string ID1 { get => ID; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<Usuario> Lista_usuarios { get => lista_usuarios; set => lista_usuarios = value; }

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
