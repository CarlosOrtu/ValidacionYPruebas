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

        public Rol(string tipo_rol, int iD, string descripcion)
        {
            this.tipo_rol = tipo_rol;
            this.ID = iD;
            this.descripcion = descripcion;
        }

        public string Tipo_rol { get => tipo_rol; }
        public int ID1 { get => ID; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public void modificarDatos(int ID, string descripcion)
        {
            this.ID = ID;
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
