using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebApplicationTest
{
    //Creamos un proyecto al cual le creamos una historia de usuario, comprobamos los elementos de esta, la modificamos y volvemos
    //a comprobar sus elementos y la borramos y comprobamos que no existe la historia.
    [TestClass]
    public class PruebaAdministrarHistoriasDeUsuario
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void ThePruebaAdministrarHistoriasDeUsuarioTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/LogIn.aspx");
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("Administrador");
            driver.FindElement(By.Id("TBPassword")).Click();
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("password_1");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Clear();
            driver.FindElement(By.Id("TextBoxCaptcha")).SendKeys("captcha");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonAdminisProyect")).Click();
            driver.FindElement(By.Id("ButtonCreateUser")).Click();
            driver.FindElement(By.Id("TextBoxName")).Click();
            driver.FindElement(By.Id("TextBoxName")).Clear();
            driver.FindElement(By.Id("TextBoxName")).SendKeys("ProyectoHU");
            driver.FindElement(By.Id("TextBoxMax")).Click();
            driver.FindElement(By.Id("TextBoxMax")).Clear();
            driver.FindElement(By.Id("TextBoxMax")).SendKeys("7");
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("Proyecto para probar historias de usuario");
            driver.FindElement(By.Id("ButtonCreateNewProject")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonHU")).Click();
            driver.FindElement(By.Id("ButtonNewHU")).Click();
            driver.FindElement(By.Id("TextBoxID")).Clear();
            driver.FindElement(By.Id("TextBoxID")).SendKeys("1");
            driver.FindElement(By.Id("TextBoxDescription")).Click();
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("Primera historia de usuario");
            driver.FindElement(By.Id("TextBoxComo")).Clear();
            driver.FindElement(By.Id("TextBoxComo")).SendKeys("Primera");
            driver.FindElement(By.Id("TextBoxQue")).Clear();
            driver.FindElement(By.Id("TextBoxQue")).SendKeys("Primera");
            driver.FindElement(By.Id("TextBoxPara")).Clear();
            driver.FindElement(By.Id("TextBoxPara")).SendKeys("Primera");
            driver.FindElement(By.Id("DropProjects")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProjects"))).SelectByText("ProyectoHU");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProject"))).SelectByText("ProyectoHU");
            driver.FindElement(By.Id("ButtonShowHU")).Click();
            driver.FindElement(By.Id("DropHU")).Click();
            new SelectElement(driver.FindElement(By.Id("DropHU"))).SelectByText("1");
            driver.FindElement(By.Id("ButtonShowData")).Click();
            try
            {
                Assert.AreEqual("1", driver.FindElement(By.Id("lblID")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Primera historia de usuario", driver.FindElement(By.Id("lblDescription")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Primera", driver.FindElement(By.Id("lblQue")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Primera", driver.FindElement(By.Id("lblComo")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Primera", driver.FindElement(By.Id("lblPara")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("ProyectoHU", driver.FindElement(By.Id("lblProject")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonChangeData")).Click();
            driver.FindElement(By.Id("DropProjects")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProjects"))).SelectByText("ProyectoHU");
            driver.FindElement(By.Id("ButtonShow")).Click();
            driver.FindElement(By.Id("DropHU")).Click();
            new SelectElement(driver.FindElement(By.Id("DropHU"))).SelectByText("1");
            driver.FindElement(By.Id("TextBoxDescription")).Click();
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("HU modificada");
            driver.FindElement(By.Id("TextBoxComo")).Click();
            driver.FindElement(By.Id("TextBoxComo")).Clear();
            driver.FindElement(By.Id("TextBoxComo")).SendKeys("Modificada");
            driver.FindElement(By.Id("TextBoxQue")).Click();
            driver.FindElement(By.Id("TextBoxQue")).Clear();
            driver.FindElement(By.Id("TextBoxQue")).SendKeys("Modificada");
            driver.FindElement(By.Id("TextBoxPara")).Click();
            driver.FindElement(By.Id("TextBoxPara")).Clear();
            driver.FindElement(By.Id("TextBoxPara")).SendKeys("Modificada");
            driver.FindElement(By.Id("DropProyects")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProyects"))).SelectByText("ProyectoHU");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProject"))).SelectByText("ProyectoHU");
            driver.FindElement(By.Id("ButtonShowHU")).Click();
            driver.FindElement(By.Id("DropHU")).Click();
            new SelectElement(driver.FindElement(By.Id("DropHU"))).SelectByText("1");
            driver.FindElement(By.Id("ButtonShowData")).Click();
            try
            {
                Assert.AreEqual("HU modificada", driver.FindElement(By.Id("lblDescription")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Modificada", driver.FindElement(By.Id("lblQue")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Modificada", driver.FindElement(By.Id("lblComo")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Modificada", driver.FindElement(By.Id("lblPara")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("ProyectoHU", driver.FindElement(By.Id("lblProject")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonDelete")).Click();
            driver.FindElement(By.Id("DropProjects")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProjects"))).SelectByText("ProyectoHU");
            driver.FindElement(By.Id("ButtonProject")).Click();
            driver.FindElement(By.Id("DropHU")).Click();
            new SelectElement(driver.FindElement(By.Id("DropHU"))).SelectByText("1");
            driver.FindElement(By.Id("ButtonDelete")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonShowHU")).Click();
            try
            {
                Assert.AreEqual(null, driver.FindElement(By.Id("DropHU")).GetAttribute("1"));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonLogOut")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
