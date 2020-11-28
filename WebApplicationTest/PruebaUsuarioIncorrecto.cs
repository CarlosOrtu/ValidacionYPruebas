using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebApplicationTest
{
    [TestFixture]
    public class PruebaUsuarioIncorrecto
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void ThePruebaUsuarioIncorrectoTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/LogIn.aspx");
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("Carlos");
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("pruebacontra");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            try
            {
                Assert.AreEqual("Usuario y/o contraseña erroneo", driver.FindElement(By.Id("lblError")).Text);
            }
            catch (AssertionException e)
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
