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
    //Creamos un usuario nuevo, accedemos a Administrador, eliminamos ese usuario 
    //y probamos a hacer login para comprobar si se ha borrado correctamente
    [TestClass]
    public class PruebaBorrarUsuario
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
        public void ThePruebaBorrarUsuarioTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/LogIn.aspx");
            driver.FindElement(By.Id("ButtonNewUser")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Clear();
            driver.FindElement(By.Id("NewTBUserName")).SendKeys("Borrar");
            driver.FindElement(By.Id("NewTBPassword")).Clear();
            driver.FindElement(By.Id("NewTBPassword")).SendKeys("borrar_1");
            driver.FindElement(By.Id("NewTBRepeatPassword")).Clear();
            driver.FindElement(By.Id("NewTBRepeatPassword")).SendKeys("borrar_1");
            driver.FindElement(By.Id("NewTBEmail")).Clear();
            driver.FindElement(By.Id("NewTBEmail")).SendKeys("borrar@gmail.com");
            driver.FindElement(By.Id("NewTBName")).Clear();
            driver.FindElement(By.Id("NewTBName")).SendKeys("Borrar");
            driver.FindElement(By.Id("NewTBSurname")).Clear();
            driver.FindElement(By.Id("NewTBSurname")).SendKeys("Borrar");
            driver.FindElement(By.Id("NewTBPhone")).Clear();
            driver.FindElement(By.Id("NewTBPhone")).SendKeys("672652617");
            driver.FindElement(By.Id("ButtonCreateNewUser")).Click();
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("Borrar");
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("borrar_1");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            driver.FindElement(By.Id("TBOldPassword")).Click();
            driver.FindElement(By.Id("TBOldPassword")).Clear();
            driver.FindElement(By.Id("TBOldPassword")).SendKeys("borrar_1");
            driver.FindElement(By.Id("TBChangePassword")).Clear();
            driver.FindElement(By.Id("TBChangePassword")).SendKeys("borrar_2");
            driver.FindElement(By.Id("TBChangePassword2")).Clear();
            driver.FindElement(By.Id("TBChangePassword2")).SendKeys("borrar_2");
            driver.FindElement(By.Id("ButtonChangePassword")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Clear();
            driver.FindElement(By.Id("TextBoxCaptcha")).SendKeys("captcha");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonLogOut")).Click();
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("Administrador");
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("password_1");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Clear();
            driver.FindElement(By.Id("TextBoxCaptcha")).SendKeys("captcha");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonAdminisUser")).Click();
            driver.FindElement(By.Id("ButtonDeleteUsers")).Click();
            driver.FindElement(By.Id("DropDownListUsers")).Click();
            new SelectElement(driver.FindElement(By.Id("DropDownListUsers"))).SelectByText("Borrar");
            driver.FindElement(By.Id("ButtonDelete")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonLogOut")).Click();
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("Borrar");
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("borrar_2");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            try
            {
                Assert.AreEqual("Usuario y/o contraseña erroneo", driver.FindElement(By.Id("lblError")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
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
