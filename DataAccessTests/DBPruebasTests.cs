using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace DataAccess.Tests
{
    [TestClass()]
    public class DBPruebasTests
    {
        Proyecto p1, p2, p1_rep;
        Usuario u1, u2, u1_rep;
        Rol r1, r2, r1_rep;
        DBPruebas b1;

        [TestInitialize]
        public void DBInicialice()
        {
            p1 = new Proyecto("proyecto1", 12, "Primer proyecto");
            p2 = new Proyecto("proyecto2", 1, "Segundo proyecto");
            p1_rep = new Proyecto("proyecto1", 7, "Proyecto repetido");

            u1 = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            u2 = new Usuario("guille", "contrasena_2", "guille@gmail.com", "guille", "saldaña", "65383927");
            u1_rep = new Usuario("carlos", "contrasena_7", "repetido@gmail.com", "repetido", "repetido", "666666666");

            r1 = new Rol("Administrador Usuarios", 1, "Usuario capaz de administrar todo lo relaccionado con usuarios");
            r2 = new Rol("Administrador Proyectos", 2, "Usuario capaz de administrar todo lo relaccionado con proyectos");
            r1_rep = new Rol("Administrador Usuarios", 4, "rol repetido");

            b1 = new DBPruebas();

            b1.insertaUsuario(u1);
            b1.insertaProyecto(p1);
            b1.insertarRol(r1);
        }

        [TestCleanup]
        public void CleanUp()
        {
            p1 = null;
            p2 = null;
            u1 = null;
            u2 = null;
            b1 = null;
        }

        [TestMethod()]
        public void InsertaUsuarioTest()
        {
            Assert.IsFalse(b1.insertaUsuario(u1)); 
            Assert.IsTrue(b1.insertaUsuario(u2));
            Assert.IsFalse(b1.insertaUsuario(u1_rep));
        }

        [TestMethod()]
        public void LeeUsuarioTest()
        {
            Assert.AreEqual(b1.leeUsuario(u1.UserName), u1);
            Assert.IsNull(b1.leeUsuario(u2.UserName));
        }

        [TestMethod()]
        public void BorraUsuarioTest()
        {
            r1.anadirUsuario(u1) ;
            p1.anadirUsuario(u1);
            Assert.AreEqual(b1.borraUsuario(u1.UserName), u1);
            Assert.IsFalse(r1.leerUsuario(u1));
            Assert.IsFalse(p1.leerUsuario(u1));
            Assert.IsNull(b1.borraUsuario(u2.UserName)); 
        }

        [TestMethod()]
        public void ModificaDatosUsuarioTest()
        {
            Usuario uMal = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            Usuario uBien = new Usuario("carlos", "contrasena_1", "carlos_nuevo@gmail.com", "carlos", "ortunez", "666666666");
            Usuario uInexistente = new Usuario("guille", "contrasena_2", "guille@gmail.com", "guille", "saldaña", "65383927");
            Assert.IsFalse(b1.modificaDatosUsuario(uMal));
            Assert.IsTrue(b1.modificaDatosUsuario(uBien));
            Assert.IsFalse(b1.modificaDatosUsuario(uInexistente));
        }

        [TestMethod()]
        public void InsertaProyectoTest()
        {
            Assert.IsFalse(b1.insertaProyecto(p1));
            Assert.IsTrue(b1.insertaProyecto(p2));
            Assert.IsFalse(b1.insertaProyecto(p1_rep));
        }

        [TestMethod()]
        public void LeeProyectoTest()
        {
            Assert.AreEqual(b1.leeProyecto(p1.Nombre), p1);
            Assert.IsNull(b1.leeProyecto(p2.Nombre));
        }

        [TestMethod()]
        public void BorraProyectoTest()
        {
            u1.anadirProyecto(p1);
            Assert.AreEqual(b1.borraProyecto(p1.Nombre), p1);
            Assert.IsFalse(u1.leerProyecto(p1));
            Assert.IsNull(b1.borraProyecto(p2.Nombre)); 
        }

        [TestMethod()]
        public void ModificaDatosProyectoTest()
        {
            Proyecto pMal = new Proyecto("proyecto1", 12, "Primer proyecto");
            Proyecto pBien = new Proyecto("proyecto1", 8, "Primer proyecto");
            Proyecto pInexistente = new Proyecto("proyecto2", 1, "Segundo proyecto");
            Assert.IsFalse(b1.modificaDatosProyecto(pMal));
            //Comprobacion si al modificar un proyecto tambien se modifica en la lista de proyectos de la clase usuario
            u1.anadirProyecto(p1);
            Assert.IsTrue(b1.modificaDatosProyecto(pBien));
            List<Proyecto> lista = u1.Lista_proyectos;
            int indice= lista.IndexOf(pBien);
            Assert.IsTrue(lista[indice].Descripcion == pBien.Descripcion && lista[indice].Max == pBien.Max);
            Assert.IsFalse(lista[indice].Descripcion == p1.Descripcion && lista[indice].Max == p1.Max);
            Assert.IsFalse(b1.modificaDatosProyecto(pInexistente));
        }

        [TestMethod()]
        public void BorrarRolTest()
        {
            u1.Rol = r1;
            Assert.AreEqual(b1.borrarRol(r1.Tipo_rol), r1);
            Assert.IsNull(u1.Rol);
            Assert.IsNull(b1.borrarRol(r2.Tipo_rol));
        }

        [TestMethod()]
        public void InsertarRolTest()
        {
            Assert.IsTrue(b1.insertarRol(r2));
            Assert.IsFalse(b1.insertarRol(r1));
            Assert.IsFalse(b1.insertarRol(r1_rep));
        }

        [TestMethod()]
        public void LeeRolTest()
        {
            Assert.AreEqual(b1.leeRol(r1.Tipo_rol), r1);
            Assert.IsNull(b1.leeRol(r2.Tipo_rol));
        }

        [TestMethod()]
        public void ModificaDatosRolTest()
        {
            Rol rMal = new Rol("Administrador Usuarios", 1, "Usuario capaz de administrar todo lo relaccionado con usuarios");
            Rol rBien = new Rol("Administrador Usuarios", 1, "Nueva descripción");
            Rol rInexistente = new Rol("proyecto2", 1, "Segundo proyecto");
            Assert.IsFalse(b1.modificaDatosRol(rMal));
            //Insertamos un rol en un usuario para comprobar si este se modifica correctamente
            u1.Rol = r1;
            Assert.IsTrue(b1.modificaDatosRol(rBien));
            Assert.IsTrue(u1.Rol.Descripcion == rBien.Descripcion);
            Assert.IsFalse(b1.modificaDatosRol(rInexistente));
        }
    }
}