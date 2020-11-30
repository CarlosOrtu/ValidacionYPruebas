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
    //Creamos un rol y comprobamos todos sus campos, lo modificamos y comprobamos los campos modificados y lo eliminamos 
    //y comprobamos que no existe
    [TestClass]
    public class PruebaAdministrarRolesProyecto
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
        public void ThePruebaAdministrarRolesProyectoTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/LogIn.aspx");
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
            driver.FindElement(By.Id("ButtonAdminisProyect")).Click();
            driver.FindElement(By.Id("ButtonAdminRoles")).Click();
            driver.FindElement(By.Id("Button1")).Click();
            driver.FindElement(By.Id("TextBoxName")).Click();
            driver.FindElement(By.Id("TextBoxName")).Clear();
            driver.FindElement(By.Id("TextBoxName")).SendKeys("RolPrueba1");
            driver.FindElement(By.Id("TextBoxID")).Click();
            driver.FindElement(By.Id("TextBoxID")).Clear();
            driver.FindElement(By.Id("TextBoxID")).SendKeys("10");
            driver.FindElement(By.Id("TextBoxDescription")).Click();
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("Rol de prueba 1");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("DropRoles")).Click();
            new SelectElement(driver.FindElement(By.Id("DropRoles"))).SelectByText("RolPrueba1");
            driver.FindElement(By.Id("ButtonShow")).Click();
            try
            {
                Assert.AreEqual("RolPrueba1", driver.FindElement(By.Id("lblNombre")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("10", driver.FindElement(By.Id("lblID")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Rol de prueba 1", driver.FindElement(By.Id("lblDescription")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonChangeRol")).Click();
            driver.FindElement(By.Id("TextBoxID")).Click();
            driver.FindElement(By.Id("TextBoxID")).Clear();
            driver.FindElement(By.Id("TextBoxID")).SendKeys("10");
            driver.FindElement(By.Id("TextBoxDescription")).Click();
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("Rol de prueba modificado");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("DropRoles")).Click();
            new SelectElement(driver.FindElement(By.Id("DropRoles"))).SelectByText("RolPrueba1");
            driver.FindElement(By.Id("ButtonShow")).Click();
            try
            {
                Assert.AreEqual("Rol de prueba modificado", driver.FindElement(By.Id("lblDescription")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("Button2")).Click();
            driver.FindElement(By.Id("DropRol")).Click();
            driver.FindElement(By.Id("DropRol")).Click();
            driver.FindElement(By.Id("ButtonDelete")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("DropRoles")).Click();
            try
            {
                Assert.AreEqual(null, driver.FindElement(By.Id("DropRoles")).GetAttribute("RolPrueba1"));
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
