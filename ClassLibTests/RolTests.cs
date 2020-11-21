using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Tests
{
    [TestClass()]
    public class RolTests
    {
        Rol r1, r2, r1_2;

        [TestInitialize]
        public void ProyectInicialice()
        {
            r1 = new Rol("Administrador Usuarios", 1, "Usuario capaz de administrar todo lo relaccionado con usuarios");
            r2 = new Rol("Administrador Proyectos", 2, "Usuario capaz de administrar todo lo relaccionado con proyectos");
            r1_2 = new Rol("Administrador Usuarios", 3, "Administrador de usuarios Test");

        }

        [TestCleanup]
        public void CleanUp()
        {
            r1 = null;
            r2 = null;
            r1_2 = null;
        }

        [TestMethod()]
        public void RolTest()
        {
            Assert.IsTrue(r1.Tipo_rol == "Administrador Usuarios" && r1.ID1 == 1 && r1.Descripcion == "Usuario capaz de administrar todo lo relaccionado con usuarios");
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