﻿using System;
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
            uAdmin.Active = true;
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
                List<Proyecto> auxP = new List<Proyecto>();
                auxP = tblProyectos.Values.ToList();
                //Buscamos en todos los proyectos los que tengan este usuario y lo retiramos
                foreach (Proyecto p1 in auxP)
                {
                    if (p1.leerUsuario(retorno))
                    {
                        tblProyectos.Remove(p1.Nombre);
                        p1.retirarUsuario(retorno);
                        tblProyectos.Add(p1.Nombre,p1);
                    }
                }
                List<Rol> auxR = new List<Rol>();
                auxR = tblRoles.Values.ToList();
                //Buscamos en todos los roles los que tengan este usuario y lo retiramos
                foreach (Rol r1 in auxR)
                {
                    if (r1.leerUsuario(retorno))
                    {
                        tblRoles.Remove(r1.Tipo_rol);
                        r1.retirarUsuario(retorno);
                        tblRoles.Add(r1.Tipo_rol, r1);
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
                if (antiguo.Email != usuario.Email || antiguo.Phone != usuario.Phone || antiguo.Name != usuario.Name || antiguo.Surname != usuario.Surname)
                {
                    usuario.modificarDatos(usuario.Email, usuario.Name, usuario.Surname, usuario.Phone);
                    tblUsuarios.Remove(usuario.UserName);
                    tblUsuarios.Add(usuario.UserName, usuario);
                    List<Proyecto> auxP = new List<Proyecto>();
                    auxP = tblProyectos.Values.ToList();
                    //Buscamos en todos los proyectos los que tengan este usuario y lo modificamos
                    foreach (Proyecto p1 in auxP)
                    {
                        if (p1.leerUsuario(antiguo))
                        {
                            tblProyectos.Remove(p1.Nombre);
                            p1.retirarUsuario(antiguo);
                            p1.anadirUsuario(usuario);
                            tblProyectos.Add(p1.Nombre, p1);
                        }
                    }
                    List<Rol> auxR = new List<Rol>();
                    auxR = tblRoles.Values.ToList();
                    //Buscamos en todos los roles los que tengan este usuario y lo modificamos
                    foreach (Rol r1 in auxR)
                    {
                        if (r1.leerUsuario(antiguo))
                        {
                            tblRoles.Remove(r1.Tipo_rol);
                            r1.retirarUsuario(antiguo);
                            r1.anadirUsuario(usuario);
                            tblRoles.Add(r1.Tipo_rol, r1);
                        }
                    }
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
                    List<Usuario> aux = new List<Usuario>();
                    aux = tblUsuarios.Values.ToList();
                    //Buscamos en todos los usuarios los que tengan este proyecto y lo modificamos
                    foreach (Usuario u1 in aux)
                    {
                        if (u1.leerProyecto(antiguo))
                        {
                            tblUsuarios.Remove(u1.UserName);
                            u1.retirarProyecto(antiguo);
                            u1.anadirProyecto(proyecto);
                            tblUsuarios.Add(u1.UserName, u1);
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public Proyecto borraProyecto(string nombre){
            Proyecto retorno = leeProyecto(nombre);
            if (retorno!=null)
                tblProyectos.Remove(nombre);

            if (retorno != null && tblUsuarios.Any()) 
            {
                List<Usuario> aux = new List<Usuario>();
                aux = tblUsuarios.Values.ToList();
                //Buscamos en todos los usuarios los que tengan este proyecto y lo retiramos
                foreach (Usuario u1 in aux)
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
        
        public Rol borrarRol(string nombre)
        {
            Rol retorno = leeRol(nombre);
            if (retorno != null)
                tblRoles.Remove(nombre);

            if (retorno != null && tblUsuarios.Any())
            {
                List<Usuario> aux = new List<Usuario>();
                aux = tblUsuarios.Values.ToList();
                //Buscamos en todos los usuarios los que tengan este rol y lo eliminamos
                foreach (Usuario u1 in aux)
                {
                    if (u1.Rol == retorno)
                    {
                        tblUsuarios.Remove(u1.UserName);
                        u1.Rol=null;
                        tblUsuarios.Add(u1.UserName, u1);
                    }
                }
            }
            return retorno;
        }

        public Boolean insertarRol(Rol rol)
        {
            if (leeRol(rol.Tipo_rol) == null)
            {
                tblRoles.Add(rol.Tipo_rol, rol);
                return true;
            }

            return false;
        }

        public Rol leeRol(string nombre)
        {
            Rol retorno = null;
            if (!tblRoles.TryGetValue(nombre, out retorno))
                retorno = null;

            return retorno;
        }

        public Boolean modificaDatosRol(Rol rol)
        {
            if (tblRoles.ContainsKey(rol.Tipo_rol) == true)
            {
                int indice = tblRoles.IndexOfKey(rol.Tipo_rol);

                Rol antiguo = tblRoles.Values[indice];

                if (antiguo.ID1 != rol.ID1 || antiguo.Descripcion != rol.Descripcion)
                {
                    tblRoles.Remove(antiguo.Tipo_rol);
                    tblRoles.Add(rol.Tipo_rol, rol);

                    List <Usuario> aux = new List<Usuario>();
                    aux = tblUsuarios.Values.ToList();
                    //Buscamos en todos los usuarios los que tengan este rol y lo modificamos
                    foreach (Usuario u1 in aux)
                    {
                        if (u1.Rol == antiguo)
                        {
                            tblUsuarios.Remove(u1.UserName);
                            u1.Rol = rol;
                            tblUsuarios.Add(u1.UserName, u1);
                        }
                    }

                    return true;
                }
            }
            return false;
        }

    }
}
