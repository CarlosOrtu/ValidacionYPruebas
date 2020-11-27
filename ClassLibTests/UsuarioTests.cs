using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Tests
{
    [TestClass()]
    public class UsuarioTestsTests
    {
        Usuario u1, u2, u3, u1_2;
        Proyecto p1, p2, p3;

        [TestInitialize]
        public void TestInitialize()
        {
            u1 = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            u2 = new Usuario("guille", "contrasena2", "guille@gmail.com", "guille", "saldaña", "65383927");
            u3 = new Usuario("willson", "contrasena_", "willson@gmail.com", "willson", "martinez", "293839281");
            u1_2 = new Usuario("carlos", "contra", "carlosgmail.com", "carlos", "ortunez", "645432142");

            p1 = new Proyecto("proyecto1", 12, "Primer proyecto");
            p2 = new Proyecto("proyecto2", 1, "Segundo proyecto");
            p3 = new Proyecto("proyecto3", 3, "Tercer proyecto");

            u1.AnadirProyecto(p1);
            u1.AnadirProyecto(p2);
            u1.AnadirProyecto(p3);
        }

        [TestCleanup]
        public void CleanUp()
        {
            u1 = null;
            u2 = null;
            u3 = null;
            u1_2 = null;
            p1 = null;
            p2 = null;
            p3 = null;
        }

        [TestMethod()]
        public void UsuarioTest()
        {
            Assert.IsTrue(u1.UserName == "carlos" && u1.Email == "carlos@gmail.com" && u1.Name == "carlos" && u1.Surname == "ortunez" && u1.Phone == "645432142");
        }

        [TestMethod()]
        public void CheckEmailTest()
        {
            Assert.IsTrue(u1.CheckEmail(u1.Email));
            Assert.IsFalse(u1_2.CheckEmail(u1_2.Email));
        }

        [TestMethod()]
        public void CheckPhoneTest()
        {
            Assert.IsTrue(u1.CheckPhone());
            Assert.IsFalse(u2.CheckPhone());
        }

        [TestMethod()]
        public void ChangePasswordTest()
        {
            Assert.IsFalse(u1.ChangePassword("contrasena_1", "contrasena_1"));
            Assert.IsFalse(u1.ChangePassword("contrasena2", "contrasena5"));
            Assert.IsFalse(u1.ChangePassword("contrasena_1", "contrasena_"));
            Assert.IsFalse(u1.ChangePassword("contrasena_1", "contrasena6"));
            Assert.IsTrue(u1.ChangePassword("contrasena_1", "contrasena_nueva1"));
        }

        [TestMethod()]
        public void SyntaxPasswordTest()
        {
            Assert.IsFalse(u1.SyntaxPassword("contr"));
            Assert.IsFalse(u1.SyntaxPassword("contrasena_"));
            Assert.IsFalse(u1.SyntaxPassword("contrasena1"));
            Assert.IsTrue(u1.SyntaxPassword("contrasena_nueva1"));
        }

        [TestMethod()]
        public void CheckPasswordTest()
        {
            Assert.IsTrue(u1.CheckPassword("contrasena_1"));
            Assert.IsFalse(u1.CheckPassword("contrasena_2"));
        }

        [TestMethod()]
        public void LogInTest()
        {
            Assert.IsFalse(u1.LogIn("carlos", "contrasena_1"));
            Assert.IsFalse(u1.LogIn("carlos", "contrasena2"));
            u1.ChangePassword("contrasena_1", "contrasena_nueva1");
            Assert.IsFalse(u1.LogIn("carlos", "contrasena_1"));
            Assert.IsTrue(u1.LogIn("carlos", "contrasena_nueva1"));
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Assert.IsFalse(u1.Equals(u2));
            Assert.IsTrue(u1_2.Equals(u1));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.AreEqual(u1.GetHashCode(), u1_2.GetHashCode());
            Assert.AreNotEqual(u1.GetHashCode(), u3.GetHashCode());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.AreEqual(u1.CompareTo(u1_2.UserName), 0);
            Assert.AreNotEqual(u1.CompareTo(u2.UserName), 0);
        }

        [TestMethod()]
        public void AnadirProyectoTest()
        {
            Assert.IsTrue(u2.AnadirProyecto(p1));
            Assert.IsFalse(u1.AnadirProyecto(p1));
            Assert.IsFalse(u1.AnadirProyecto(p2));
        }

        [TestMethod()]
        public void RetirarProyectotest()
        {
            Assert.IsTrue(u1.RetirarProyecto(p1));
            Assert.IsTrue(u1.RetirarProyecto(p2));
            Assert.IsTrue(u1.RetirarProyecto(p3));
            Assert.IsFalse(u1.RetirarProyecto(p1));
        }

        [TestMethod()]
        public void EliminarProyectosTest()
        {
            Assert.IsTrue(u1.EliminarProyectos());
            Assert.IsFalse(u1.EliminarProyectos());
        }

        [TestMethod()]
        public void LeerProyectosTest()
        {
            Assert.IsTrue(u1.LeerProyecto(p1));
            Assert.IsTrue(u1.LeerProyecto(p2));
            Assert.IsTrue(u1.LeerProyecto(p3));
            Assert.IsFalse(u2.LeerProyecto(p2));
        }

        [TestMethod()]
        public void ModificarDatosTest()
        {
            u1.ModificarDatos("carlosOrtunez@gmail.com", "Carlitos", "Ortuñez", "654782310");
            Assert.AreEqual(u1.Email, "carlosOrtunez@gmail.com");
            Assert.AreEqual(u1.Name, "Carlitos");
            Assert.AreEqual(u1.Surname, "Ortuñez");
            Assert.AreEqual(u1.Phone, "654782310");
            u2.ModificarDatos("guillehotmail.es", "Guilllermo", "Saldaña", "2345");
            Assert.AreNotEqual(u2.Email, "guillehotmail.es"); //No es igual porque el email no cumple los requisitos.
            Assert.AreEqual(u2.Name, "Guilllermo");
            Assert.AreEqual(u2.Surname, "Saldaña");
            Assert.AreNotEqual(u2.Phone, "2345"); //No es igual porque el telefono no cumple los requisitos.
        }
    }
}