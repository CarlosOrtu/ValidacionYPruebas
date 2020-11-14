using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Tests
{
    [TestClass()]
    public class ProyectoTest
    {
        Proyecto p1, p2, p3, p1_2;
        Usuario u1, u2, u3;

        [TestInitialize]
        public void ProyectInicialice()
        {
            p1 = new Proyecto("proyecto1", 12, "Primer proyecto");
            p2 = new Proyecto("proyecto2", 1, "Segundo proyecto");
            p3 = new Proyecto("proyecto3", 3, "Tercer proyecto");
            p1_2 = new Proyecto("proyecto1", 45, "Segunda parte del primer proyecto");

            u1 = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            u2 = new Usuario("guille", "contrasena2", "guille@gmail.com", "guille", "saldaña", "65383927");
            u3 = new Usuario("willson", "contrasena_", "willson@gmail.com", "willson", "martinez", "293839281");

            p1.anadirUsuario(u1);
            p1.anadirUsuario(u2);
            p1.anadirUsuario(u3);
            p2.anadirUsuario(u1);
        }

        [TestCleanup]
        public void CleanUp()
        {
            p1 = null;
            p2 = null;
            p3 = null;
            p1_2 = null;
            u1 = null;
            u2 = null;
            u3 = null;
        }

        [TestMethod]
        public void getTest()
        {
            Assert.IsTrue(p1.Nombre == "proyecto1" && p1.Max == 12 && p1.Descripcion == "Primer proyecto");
            Assert.IsTrue(p2.Nombre == "proyecto2" && p2.Max == 1 && p2.Descripcion == "Segundo proyecto");
            Assert.IsTrue(p3.Nombre == "proyecto3" && p3.Max == 3 && p3.Descripcion == "Tercer proyecto");
        }

        [TestMethod]
        public void anadirUsuarioTest()
        {
            Assert.IsFalse(p2.anadirUsuario(u1)); //Falso por ser un usuario qeu ya está en el proyecto.
            Assert.IsFalse(p2.anadirUsuario(u2)); //Falso por superar el máximo de participantes del proyecto.
        }

        [TestMethod]
        public void retirarUsuariosTest()
        {
            Assert.IsTrue(p1.retirarUsuario(u1));
            Assert.IsTrue(p1.retirarUsuario(u2));
            Assert.IsTrue(p1.retirarUsuario(u3));
            Assert.IsFalse(p1.retirarUsuario(u2));
            Assert.IsFalse(p3.retirarUsuario(u2));
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
            Assert.IsTrue(p1.leerUsuario(u2));
            Assert.IsFalse(p3.leerUsuario(u1));
            Assert.IsFalse(p2.leerUsuario(u2));
        }

        [TestMethod]
        public void EqualsTest()
        {
            Assert.IsTrue(p1.Equals(p1));
            Assert.IsTrue(p1.Equals(p1_2));
            Assert.IsFalse(p1.Equals(p2));
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