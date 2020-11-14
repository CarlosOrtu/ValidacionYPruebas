using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using Interfaces;

namespace DataAccess
{
    public class DBPruebas : ICapaDatos
    {
        private SortedList<string, Usuario> tblUsuarios = new SortedList<string, Usuario>();
        private SortedList<string, Proyecto> tblProyectos = new SortedList<string, Proyecto>();
        private SortedList<string, Rol> tblRoles = new SortedList<string, Rol>();

        public SortedList<string, Usuario> TblUsuarios { get => tblUsuarios; set => tblUsuarios = value; }
        public SortedList<string, Proyecto> TblProyectos { get => tblProyectos; set => tblProyectos = value; }
        public SortedList<string, Rol> TblRoles { get => tblRoles; set => tblRoles = value; }

        public DBPruebas()
        {            
            // Inicilización de los elementos de la base de datos             
            Usuario uAdmin = new Usuario("Administrador","password1", "admin@ubu.es", "Administración", "Proyectos", "947342378");
            uAdmin.AdministradorProyectos = true;
            uAdmin.AdministradorUsuarios = true;
            tblUsuarios.Add(uAdmin.UserName, uAdmin);
        }

        public Usuario borraUsuario(string userName)
        {
            Usuario retorno = leeUsuario(userName);
            if (retorno!=null)
                tblUsuarios.Remove(userName);

            if (retorno != null && tblProyectos.Any()) 
            {
                foreach(Proyecto p1 in tblProyectos.Values)
                {
                    if (p1.leerUsuario(retorno))
                    {
                        tblProyectos.Remove(p1.Nombre);
                        p1.retirarUsuario(retorno);
                        tblProyectos.Add(p1.Nombre,p1);
                    }
                }
            }
            return retorno;
        }

        public bool insertaUsuario(Usuario user)
        {
            if (leeUsuario(user.UserName) == null)
            {
                tblUsuarios.Add(user.UserName, user);
                return true;
            }

            return false;
        }

        public Usuario leeUsuario(string userName)
        {
            Usuario retorno = null; 
            if (!tblUsuarios.TryGetValue(userName, out retorno)) 
                retorno = null; 
            
            return retorno;
        }

        public bool modificaDatosUsuario(Usuario usuario)
        {
            if (tblUsuarios.ContainsKey(usuario.UserName) == true)
            {
                int indice = tblUsuarios.IndexOfKey(usuario.UserName);

                Usuario antiguo = tblUsuarios.Values[indice];
                int valor = 0;
                if (antiguo.Email != usuario.Email || antiguo.Phone != usuario.Phone || antiguo.Name != usuario.Name || antiguo.Surname != usuario.Surname)
                {
                    usuario.modificarDatos(usuario.Email, usuario.Name, usuario.Surname, usuario.Phone);
                    tblUsuarios.Remove(usuario.UserName);
                    tblUsuarios.Add(usuario.UserName, usuario);

                    return true;
                }
            }
            return false;
        }


        public bool insertaProyecto(Proyecto proyecto)
        {
            if (leeProyecto(proyecto.Nombre) == null)
            {
                tblProyectos.Add(proyecto.Nombre, proyecto);
                return true;
            }

            return false;
        }

        public Proyecto leeProyecto(string nombre)
        {
            Proyecto retorno = null;
            if (!tblProyectos.TryGetValue(nombre, out retorno))
                retorno = null;

            return retorno;
        }

        public bool modificaDatosProyecto(Proyecto proyecto)
        {
            if (tblProyectos.ContainsKey(proyecto.Nombre) == true)
            {
                int indice = tblProyectos.IndexOfKey(proyecto.Nombre);

                Proyecto antiguo = tblProyectos.Values[indice];

                if (antiguo.Max != proyecto.Max || antiguo.Descripcion != proyecto.Descripcion)
                {
                    proyecto.modificarDatos(proyecto.Max,proyecto.Descripcion);
                    tblProyectos.Remove(proyecto.Nombre);
                    tblProyectos.Add(proyecto.Nombre,proyecto);

                    return true;
                }
            }
            return false;
        }

        public Proyecto borraProyecto(string nombre){
            Proyecto retorno = leeProyecto(nombre);
            if (retorno!=null)
                tblProyectos.Remove(nombre);

            if (retorno != null && tblProyectos.Any()) 
            {
                foreach(Usuario u1 in tblUsuarios.Values)
                {
                    if (u1.leerProyecto(retorno))
                    {
                        tblUsuarios.Remove(u1.UserName);
                        u1.retirarProyecto(retorno);
                        tblUsuarios.Add(u1.UserName, u1);
                    }
                }
            }
            return retorno;
        } 
    }
}
