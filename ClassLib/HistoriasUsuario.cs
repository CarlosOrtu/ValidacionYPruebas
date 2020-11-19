using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class HistoriasUsuario : IComparable
    {
        private int ID;
        private String descripcion;
        private String como;
        private String que;
        private String paraQue;
        private Proyecto proyectoAsociado;

        public HistoriasUsuario(int ID, string descripcion, string como, string que, string paraQue, Proyecto proyectoAsociado)
        {
            this.ID = ID;
            this.descripcion = descripcion;
            this.como = como;
            this.que = que;
            this.paraQue = paraQue;
            this.proyectoAsociado = proyectoAsociado;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Como { get => como; set => como = value; }
        public string Que { get => que; set => que = value; }
        public string ParaQue { get => paraQue; set => paraQue = value; }
        public Proyecto ProyectoAsociado { get => proyectoAsociado; set => proyectoAsociado = value; }

        public int CompareTo(object obj)
        {
            return ID.CompareTo(obj);
        }

        public override bool Equals(object obj)
        {
            return obj is HistoriasUsuario usuario &&
                   ID == usuario.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + ID.GetHashCode();
        }

        public void modificarDatos(string descripcion, string como, string que, string paraQue, Proyecto proyectoAsociado)
        {
            this.descripcion = descripcion;
            this.como = como;
            this.que = que;
            this.paraQue = paraQue;
            this.proyectoAsociado = proyectoAsociado;
        }
    }
}
