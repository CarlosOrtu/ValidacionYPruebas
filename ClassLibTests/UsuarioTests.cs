using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Tests
{
    [TestClass()]
    public class UsuarioTestsTests
    {
        Usuario u1, u2, u3, u1_2;

        [TestInitialize]
        public void TestInitialize()
        {
            u1 = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            u2 = new Usuario("guille", "contrasena2", "guille@gmail.com", "guille", "saldaña", "65383927");
            u3 = new Usuario("willson", "contrasena_", "willson@gmail.com", "willson", "martinez", "293839281");
            u1_2 = new Usuario("carlos", "contra", "carlosgmail.com", "carlos", "ortunez", "645432142");
        }
        [TestCleanup]
        public void CleanUp()
        {
            u1 = null;
            u2 = null;
            u3 = null;
            u1_2 = null;
        }
        [TestMethod()]
        public void UsuarioTest()
        {
            Assert.IsTrue(u1.UserName == "carlos" && u1.Email == "carlos@gmail.com" && u1.Name == "carlos" && u1.Surname == "ortunez" && u1.Phone == "645432142");
        }


        [TestMethod()]
        public void checkEmailTest()
        {
            Assert.IsTrue(u1.checkEmail(u1.Email));
            Assert.IsFalse(u1_2.checkEmail(u1_2.Email));
        }

        [TestMethod()]
        public void checkPhoneTest()
        {
            Assert.IsTrue(u1.checkPhone());
            Assert.IsFalse(u2.checkPhone());
        }

        [TestMethod()]
        public void changePasswordTest()
        {
            Assert.IsFalse(u1.changePassword("contrasena_1", "contrasena_1"));
            Assert.IsFalse(u1.changePassword("contrasena2", "contrasena5"));
            Assert.IsFalse(u1.changePassword("contrasena_1", "contrasena_"));
            Assert.IsFalse(u1.changePassword("contrasena_1", "contrasena6"));
            Assert.IsTrue(u1.changePassword("contrasena_1", "contrasena_nueva1"));
        }

        [TestMethod()]
        public void checkPasswordTest()
        {
            Assert.IsFalse(u1.checkPassword("contr"));
            Assert.IsFalse(u1.checkPassword("contrasena_"));
            Assert.IsFalse(u1.checkPassword("contrasena1"));
            Assert.IsTrue(u1.checkPassword("contrasena_nueva1"));
        }

        [TestMethod()]
        public void logInTest()
        {
            Assert.IsFalse(u1.logIn("carlos", "contrasena_1"));
            Assert.IsFalse(u1.logIn("carlos", "contrasena2"));
            u1.changePassword("contrasena_1", "contrasena_nueva1");
            Assert.IsFalse(u1.logIn("carlos", "contrasena_1"));
            Assert.IsTrue(u1.logIn("carlos", "contrasena_nueva1"));
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
    }
}