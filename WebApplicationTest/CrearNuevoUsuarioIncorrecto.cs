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
    //Creamos un usuario equivocandonos en la contraseña
    [TestClass]
    public class CrearNuevoUsuarioIncorrecto
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
        public void TheCrearNuevoUsuarioIncorrectoTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/LogIn.aspx");
            driver.FindElement(By.Id("ButtonNewUser")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Clear();
            driver.FindElement(By.Id("NewTBUserName")).SendKeys("CarlosYo");
            driver.FindElement(By.Id("NewTBPassword")).Clear();
            driver.FindElement(By.Id("NewTBPassword")).SendKeys("contraseñamal");
            driver.FindElement(By.Id("NewTBRepeatPassword")).Click();
            driver.FindElement(By.Id("NewTBRepeatPassword")).Clear();
            driver.FindElement(By.Id("NewTBRepeatPassword")).SendKeys("contraseñamal");
            driver.FindElement(By.Id("NewTBEmail")).Click();
            driver.FindElement(By.Id("NewTBEmail")).Clear();
            driver.FindElement(By.Id("NewTBEmail")).SendKeys("cor1001@alu.ubu.es");
            driver.FindElement(By.Id("NewTBName")).Click();
            driver.FindElement(By.Id("NewTBName")).Clear();
            driver.FindElement(By.Id("NewTBName")).SendKeys("Carlos");
            driver.FindElement(By.Id("NewTBSurname")).Clear();
            driver.FindElement(By.Id("NewTBSurname")).SendKeys("Ortunez");
            driver.FindElement(By.Id("NewTBPhone")).Clear();
            driver.FindElement(By.Id("NewTBPhone")).SendKeys("717117171");
            driver.FindElement(By.Id("ButtonCreateNewUser")).Click();
            try
            {
                Assert.AreEqual("La contraseña debe tener al menos 7 caracteres, un número y un guión bajo '_'", driver.FindElement(By.Id("ErrorPassword")).Text);
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
