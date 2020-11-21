using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Tests
{
    [TestClass()]
    public class ProyectoTest
    {
        Proyecto p1, p2, p3, p1_2;
        Usuario u1, u2;
        Rol r1, r2;

        [TestInitialize]
        public void ProyectInicialice()
        {
            p1 = new Proyecto("proyecto1", 12, "Primer proyecto");
            p2 = new Proyecto("proyecto2", 1, "Segundo proyecto");
            p3 = new Proyecto("proyecto_vacio", 3, "Vacio");
            p1_2 = new Proyecto("proyecto1", 5, "Proyecto copia");

            u1 = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            u2 = new Usuario("guille", "contrasena2", "guille@gmail.com", "guille", "saldaña", "65383927");

            r1 = new Rol("Administrador Usuarios", 1, "Usuario capaz de administrar todo lo relaccionado con usuarios");
            r2 = new Rol("Administrador Proyectos", 2, "Usuario capaz de administrar todo lo relaccionado con proyectos");

            p1.anadirUsuarioConRol(u1,r1);
            p2.anadirUsuarioConRol(u1,r1);
        }

        [TestCleanup]
        public void CleanUp()
        {
            p1 = null;
            p2 = null;
            u1 = null;
            u2 = null;
            r1 = null;
            r2 = null;
        }

        [TestMethod]
        public void getTest()
        {
            Assert.IsTrue(p1.Nombre == "proyecto1" && p1.Max == 12 && p1.Descripcion == "Primer proyecto");
            Assert.IsFalse(p2.Nombre == "proyecto3" && p2.Max == 23 && p2.Descripcion == "Proyecto segundo");
        }

        [TestMethod]
        public void anadirUsuarioTest()
        {
            Assert.IsTrue(p1.anadirUsuarioConRol(u2,r1));
            Assert.IsFalse(p2.anadirUsuarioConRol(u1, r1)); //Falso por ser un usuario qeu ya está en el proyecto.
            Assert.IsFalse(p2.anadirUsuarioConRol(u2, r2)); //Falso por superar el máximo de participantes del proyecto.
        }

        [TestMethod]
        public void retirarUsuariosTest()
        {
            Assert.IsTrue(p1.retirarUsuario(u1));
            Assert.IsFalse(p1.retirarUsuario(u1)); //Falso porque lo acabamos de retirar
            Assert.IsFalse(p2.retirarUsuario(u2)); //Falso porque el usuario 2 no esta en el proyecto 3
        }

        [TestMethod]
        public void EliminarIntegrantesTest()
        {
            Assert.IsTrue(p1.eliminarIntegrantesProyecto());
            Assert.IsFalse(p3.eliminarIntegrantesProyecto()); //Falso porque no tiene ningún ususario asignado al proyecto
        }

        [TestMethod]
        public void leerUsuarioTest()
        {
            Assert.IsTrue(p1.leerUsuario(u1));
            Assert.IsFalse(p2.leerUsuario(u2)); //Falso por el mismo motivo que en el caso anterior.
        }

        [TestMethod]
        public void EqualsTest()
        {
            Assert.IsTrue(p1.Equals(p1));
            Assert.IsTrue(p1.Equals(p1_2)); //A pesar de ser dos proyectos distintos tienen el mismo nombre lo que les hace iguales.
            Assert.IsFalse(p1.Equals(p2)); //Falso porque tienen distinto nombre.
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.AreEqual(p1.GetHashCode(), p1_2.GetHashCode());
            Assert.AreNotEqual(p1.GetHashCode(), p3.GetHashCode());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.AreEqual(p1.CompareTo(p1_2.Nombre), 0);
            Assert.AreNotEqual(p1.CompareTo(p2.Nombre), 0);
        }
    }
}