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
    //Comprobamos si se puede acceder a la pagina principal sin haber iniciado sesion, creamos un usuario y comprobamos si este
    //puede accerder a la pagina de administracion de usuarios y de proyectos.
    [TestClass]
    public class PruebaDeSeguridad
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
        public void ThePruebaDeSeguridadTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/Homepage.aspx");
            try
            {
                Assert.AreEqual("Inicio de sesión", driver.FindElement(By.XPath("//form[@id='form1']/div[3]/table/caption/strong")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonNewUser")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Clear();
            driver.FindElement(By.Id("NewTBUserName")).SendKeys("UsuarioSinAdminis");
            driver.FindElement(By.Id("NewTBPassword")).Clear();
            driver.FindElement(By.Id("NewTBPassword")).SendKeys("usuario_1");
            driver.FindElement(By.Id("NewTBRepeatPassword")).Clear();
            driver.FindElement(By.Id("NewTBRepeatPassword")).SendKeys("usuario_1");
            driver.FindElement(By.Id("NewTBEmail")).Clear();
            driver.FindElement(By.Id("NewTBEmail")).SendKeys("usuarionormal@gmail.com");
            driver.FindElement(By.Id("NewTBName")).Clear();
            driver.FindElement(By.Id("NewTBName")).SendKeys("UsuarioN");
            driver.FindElement(By.Id("NewTBSurname")).Clear();
            driver.FindElement(By.Id("NewTBSurname")).SendKeys("Normal");
            driver.FindElement(By.Id("NewTBPhone")).Clear();
            driver.FindElement(By.Id("NewTBPhone")).SendKeys("676372617");
            driver.FindElement(By.Id("ButtonCreateNewUser")).Click();
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("UsuarioSin");
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("UsuarioSinAdminis");
            driver.FindElement(By.Id("TBPassword")).Click();
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("usuario_1");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            driver.FindElement(By.Id("TBOldPassword")).Click();
            driver.FindElement(By.Id("TBOldPassword")).Clear();
            driver.FindElement(By.Id("TBOldPassword")).SendKeys("usuario_1");
            driver.FindElement(By.Id("TBChangePassword")).Clear();
            driver.FindElement(By.Id("TBChangePassword")).SendKeys("usuario_2");
            driver.FindElement(By.Id("TBChangePassword2")).Clear();
            driver.FindElement(By.Id("TBChangePassword2")).SendKeys("usuario_2");
            driver.FindElement(By.Id("ButtonChangePassword")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Clear();
            driver.FindElement(By.Id("TextBoxCaptcha")).SendKeys("captcha");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.Navigate().GoToUrl("https://localhost:44390/ProjectAdministration.aspx");
            try
            {
                Assert.AreEqual("Menu Principal", driver.FindElement(By.XPath("//form[@id='form1']/table/caption/strong")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.Navigate().GoToUrl("https://localhost:44390/UserAdministration.aspx");
            try
            {
                Assert.AreEqual("Menu Principal", driver.FindElement(By.XPath("//form[@id='form1']/table/caption/strong")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
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
