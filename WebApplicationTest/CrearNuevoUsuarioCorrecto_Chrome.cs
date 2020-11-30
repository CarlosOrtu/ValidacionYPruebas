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
    //Creamos un usuario, comprobamos el inicio de sesion de este usuario, comprobamos la verificacion mediante el cambio de contraseña 
    //y comprobamos el captcha.
    [TestClass]
    public class CrearNuevoUsuarioCorrecto_Chrome
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
        public void TheCrearNuevoUsuarioCorrectoTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/LogIn.aspx");
            driver.FindElement(By.Id("ButtonNewUser")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Clear();
            driver.FindElement(By.Id("NewTBUserName")).SendKeys("Carlos");
            driver.FindElement(By.Id("NewTBPassword")).Clear();
            driver.FindElement(By.Id("NewTBPassword")).SendKeys("contrasena_1");
            driver.FindElement(By.Id("NewTBRepeatPassword")).Clear();
            driver.FindElement(By.Id("NewTBRepeatPassword")).SendKeys("contrasena_1");
            driver.FindElement(By.Id("NewTBEmail")).Clear();
            driver.FindElement(By.Id("NewTBEmail")).SendKeys("cor1001@gmail.com");
            driver.FindElement(By.Id("NewTBName")).Clear();
            driver.FindElement(By.Id("NewTBName")).SendKeys("Carlos");
            driver.FindElement(By.Id("NewTBSurname")).Clear();
            driver.FindElement(By.Id("NewTBSurname")).SendKeys("Ortunez");
            driver.FindElement(By.Id("NewTBPhone")).Clear();
            driver.FindElement(By.Id("NewTBPhone")).SendKeys("673827638");
            driver.FindElement(By.Id("ButtonCreateNewUser")).Click();
            try
            {
                Assert.AreEqual("Inicio de sesión", driver.FindElement(By.XPath("//form[@id='form1']/div[3]/table/caption/strong")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("Carlos");
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("contrasena_1");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            try
            {
                Assert.AreEqual("Cambio de contraseña", driver.FindElement(By.XPath("//form[@id='form1']/div[3]/table/caption/strong")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("TBOldPassword")).Click();
            driver.FindElement(By.Id("TBOldPassword")).Clear();
            driver.FindElement(By.Id("TBOldPassword")).SendKeys("contrasena_1");
            driver.FindElement(By.Id("TBChangePassword")).Clear();
            driver.FindElement(By.Id("TBChangePassword")).SendKeys("contrasena_2");
            driver.FindElement(By.Id("TBChangePassword2")).Clear();
            driver.FindElement(By.Id("TBChangePassword2")).SendKeys("contrasena_2");
            driver.FindElement(By.Id("ButtonChangePassword")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Clear();
            driver.FindElement(By.Id("TextBoxCaptcha")).SendKeys("captchamal");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            try
            {
                Assert.AreEqual("Incorrecto", driver.FindElement(By.Id("LabelError")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("TextBoxCaptcha")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Clear();
            driver.FindElement(By.Id("TextBoxCaptcha")).SendKeys("captcha");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            try
            {
                Assert.AreEqual("Menu Principal", driver.FindElement(By.XPath("//form[@id='form1']/table/caption/strong")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Carlos", driver.FindElement(By.Id("lblUserName")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonLogOut")).Click();
            try
            {
                Assert.AreEqual("Inicio de sesión", driver.FindElement(By.XPath("//form[@id='form1']/div[3]/table/caption/strong")).Text);
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
