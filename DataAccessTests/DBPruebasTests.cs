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
        Proyecto p1, p2, p3, p1_2;
        Usuario u1, u2, u3;
        DBPruebas b1;

        [TestInitialize]
        public void DBInicialice()
        {
            p1 = new Proyecto("proyecto1", 12, "Primer proyecto");
            p2 = new Proyecto("proyecto2", 1, "Segundo proyecto");
            p3 = new Proyecto("proyecto3", 3, "Tercer proyecto");
            p1_2 = new Proyecto("proyecto1", 45, "Segunda parte del primer proyecto");

            u1 = new Usuario("carlos", "contrasena_1", "carlos@gmail.com", "carlos", "ortunez", "645432142");
            u2 = new Usuario("guille", "contrasena_2", "guille@gmail.com", "guille", "saldaña", "65383927");
            u3 = new Usuario("willson", "contrasena_3", "willson@gmail.com", "willson", "martinez", "293839281");

            b1 = new DBPruebas();

            b1.insertaUsuario(u1);
            b1.insertaProyecto(p1);
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
            b1 = null;
        }

        [TestMethod()]
        public void insertaUsuarioTest()
        {
            Assert.IsFalse(b1.insertaUsuario(u1)); 
            Assert.IsTrue(b1.insertaUsuario(u2)); 
        }

        [TestMethod()]
        public void leeUsuarioTest()
        {
            Assert.AreEqual(b1.leeUsuario(u1.UserName), u1);
            Assert.IsNull(b1.leeUsuario(u2.UserName));
        }

        [TestMethod()]
        public void borraUsuarioTest()
        {
            Assert.AreEqual(b1.borraUsuario(u1.UserName), u1);
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
        }

        [TestMethod()]
        public void LeeProyectoTest()
        {
            Assert.AreEqual(b1.leeProyecto(p1.Nombre), p1);
            Assert.IsNull(b1.leeProyecto(p2.Nombre));
        }

        [TestMethod()]
        public void borraProyectoTest()
        {
            Assert.AreEqual(b1.borraProyecto(p1.Nombre), p1);
            Assert.IsNull(b1.borraProyecto(p2.Nombre)); 
        }

        [TestMethod()]
        public void ModificaDatosProyectoTest()
        {
            Proyecto pMal = new Proyecto("proyecto1", 12, "Primer proyecto");
            Proyecto pBien = new Proyecto("proyecto1", 8, "Primer proyecto");
            Proyecto pInexistente = new Proyecto("proyecto2", 1, "Segundo proyecto");
            Assert.IsFalse(b1.modificaDatosProyecto(pMal));
            Assert.IsTrue(b1.modificaDatosProyecto(pBien));
            Assert.IsFalse(b1.modificaDatosProyecto(pInexistente));
        }
    }
}