using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Tests
{
    [TestClass()]
    public class RolTests
    {
        Rol r1, r2, r1_2;
        Usuario u1, u2;

        [TestInitialize]
        public void ProyectInicialice()
        {
            r1 = new Rol("Administrador Usuarios", 1, "Usuario capaz de administrar todo lo relaccionado con usuarios");
            r2 = new Rol("Administrador Proyectos", 2, "Usuario capaz de administrar todo lo relaccionado con proyectos");
            r1_2 = new Rol("Administrador Usuarios", 3, "Administrador de usuarios Test");


            u1 = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            u2 = new Usuario("guille", "contrasena_2", "guille@gmail.com", "guille", "saldaña", "65383927");

            r1.anadirUsuario(u1);
        }

        [TestCleanup]
        public void CleanUp()
        {
            r1 = null;
            r2 = null;
            r1_2 = null;
            u1 = null;
            u2 = null;
        }

        [TestMethod()]
        public void RolTest()
        {
            Assert.IsTrue(r1.Tipo_rol == "Administrador Usuarios" && r1.ID1 == 1 && r1.Descripcion == "Usuario capaz de administrar todo lo relaccionado con usuarios");
        }

        [TestMethod()]
        public void anadirUsuarioTest()
        {
            Assert.IsFalse(r1.anadirUsuario(u1));
            Assert.IsTrue(r1.anadirUsuario(u2));
        }

        [TestMethod()]
        public void retirarUsuarioTest()
        {
            Assert.IsTrue(r1.retirarUsuario(u1));
            Assert.IsFalse(r1.retirarUsuario(u2));
        }

        [TestMethod()]
        public void leerUsuarioTest()
        {
            Assert.IsTrue(r1.leerUsuario(u1));
            Assert.IsFalse(r1.leerUsuario(u2));
        }

        [TestMethod()]
        public void modificarDatosTest()
        {
            r1.modificarDatos(4, "Nueva descripcion");
            Assert.IsTrue(r1.Tipo_rol == "Administrador Usuarios" && r1.Descripcion == "Nueva descripcion");
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.AreEqual(r1.CompareTo(r1_2.Tipo_rol),0);
            Assert.AreNotEqual(r1.CompareTo(r2.Tipo_rol), 0);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Assert.IsTrue(r1.Equals(r1_2));
            Assert.IsFalse(r1.Equals(r2));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.AreEqual(r1.GetHashCode(),r1_2.GetHashCode());
            Assert.AreNotEqual(r1.GetHashCode(), r2.GetHashCode());
        }
    }
}