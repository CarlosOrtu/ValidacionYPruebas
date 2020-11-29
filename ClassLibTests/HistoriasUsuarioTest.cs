using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLib.Tests
{

    [TestClass()]
    public class HistoriasUsuarioTest
    {
        HistoriasUsuario h1, h1_2, h2, h3;
        Proyecto p1, p2;

        [TestInitialize]
        public void TestInitialize()
        {
            p1 = new Proyecto("proyecto1", 12, "Primer proyecto");
            p2 = new Proyecto("proyecto2", 1, "Segundo proyecto");

            h1 = new HistoriasUsuario(1, "Primera historia", "como1", "que1", "paraQue1", p1);
            h1_2 = new HistoriasUsuario(1, "Primera historia (Segunda parte)", "como1.2", "que1.2", "paraQue1.2", p1);
            h2 = new HistoriasUsuario(2, "Segunda historia", "como2", "que2", "paraQue2", p1);
            h3 = new HistoriasUsuario(3, "Tercera historia", "como3", "que3", "paraQue3", p2);

        }

        [TestCleanup]
        public void CleanUp()
        {
            h1 = null;
            h2 = null;
            h3 = null;
            h1_2 = null;
            p1 = null;
            p2 = null;
        }

        [TestMethod()]
        public void HistoriasTest()
        {
            Assert.IsTrue(h1.ID1.Equals(1) && h1.Descripcion.Equals("Primera historia")
                && h1.Como.Equals("como1") && h1.Que.Equals("que1") && h1.ParaQue.Equals("paraQue1") && h1.ProyectoAsociado.Equals(p1));
            Assert.IsFalse(h3.ProyectoAsociado.Equals(p1)); //Falso porque no es su proyecto asociado.
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Assert.IsTrue(h1.Equals(h1_2));
            Assert.IsFalse(h1.Equals(h2));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.AreEqual(h1.GetHashCode(), h1_2.GetHashCode());
            Assert.AreNotEqual(h1.GetHashCode(), h3.GetHashCode());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.AreEqual(h1.CompareTo(h1_2.ID1), 0);
            Assert.AreNotEqual(h1.CompareTo(h2.ID1), 0);
        }

        [TestMethod()]
        public void ModificarDatosTest()
        {
            h1.ModificarDatos("Primera historia modificada", "como hacerlo", "que hacer", "para que hacerlo", p2);
            Assert.AreEqual(h1.Descripcion, "Primera historia modificada");
            Assert.AreEqual(h1.ParaQue, "para que hacerlo");
            Assert.AreNotEqual(h1.ProyectoAsociado,p1);
        }

    }
}
