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
    [TestClass]
    public class PruebaModificarDatos
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
        public void ThePruebaModificarDatosTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44390/LogIn.aspx");
            driver.FindElement(By.Id("ButtonNewUser")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Click();
            driver.FindElement(By.Id("NewTBUserName")).Clear();
            driver.FindElement(By.Id("NewTBUserName")).SendKeys("Modificar");
            driver.FindElement(By.Id("NewTBPassword")).Clear();
            driver.FindElement(By.Id("NewTBPassword")).SendKeys("modificar_1");
            driver.FindElement(By.Id("NewTBRepeatPassword")).Clear();
            driver.FindElement(By.Id("NewTBRepeatPassword")).SendKeys("modificar_1");
            driver.FindElement(By.Id("NewTBEmail")).Clear();
            driver.FindElement(By.Id("NewTBEmail")).SendKeys("modificar@gmail.com");
            driver.FindElement(By.Id("NewTBName")).Clear();
            driver.FindElement(By.Id("NewTBName")).SendKeys("modificar");
            driver.FindElement(By.Id("NewTBSurname")).Clear();
            driver.FindElement(By.Id("NewTBSurname")).SendKeys("modificar");
            driver.FindElement(By.Id("NewTBPhone")).Clear();
            driver.FindElement(By.Id("NewTBPhone")).SendKeys("656562516");
            driver.FindElement(By.Id("ButtonCreateNewUser")).Click();
            driver.FindElement(By.Id("TBUsername")).Click();
            driver.FindElement(By.Id("TBUsername")).Clear();
            driver.FindElement(By.Id("TBUsername")).SendKeys("Modificar");
            driver.FindElement(By.Id("TBPassword")).Clear();
            driver.FindElement(By.Id("TBPassword")).SendKeys("modificar_1");
            driver.FindElement(By.Id("ButtonLogIn")).Click();
            driver.FindElement(By.Id("TBOldPassword")).Click();
            driver.FindElement(By.Id("TBOldPassword")).Clear();
            driver.FindElement(By.Id("TBOldPassword")).SendKeys("modificar_1");
            driver.FindElement(By.Id("TBChangePassword")).Clear();
            driver.FindElement(By.Id("TBChangePassword")).SendKeys("modificar_2");
            driver.FindElement(By.Id("TBChangePassword2")).Clear();
            driver.FindElement(By.Id("TBChangePassword2")).SendKeys("modificar_2");
            driver.FindElement(By.Id("ButtonChangePassword")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Click();
            driver.FindElement(By.Id("TextBoxCaptcha")).Clear();
            driver.FindElement(By.Id("TextBoxCaptcha")).SendKeys("captcha");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonChangeUserDates")).Click();
            driver.FindElement(By.Id("TextBoxEmail")).Click();
            driver.FindElement(By.Id("TextBoxEmail")).Clear();
            driver.FindElement(By.Id("TextBoxEmail")).SendKeys("nuevo@gmail.com");
            driver.FindElement(By.Id("TextBoxName")).Clear();
            driver.FindElement(By.Id("TextBoxName")).SendKeys("Nuevo");
            driver.FindElement(By.Id("TextBoxSurname")).Clear();
            driver.FindElement(By.Id("TextBoxSurname")).SendKeys("Nuevo");
            driver.FindElement(By.Id("TextBoxPhone")).Clear();
            driver.FindElement(By.Id("TextBoxPhone")).SendKeys("666346634");
            driver.FindElement(By.Id("ButtonChange")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            try
            {
                Assert.AreEqual("Nuevo", driver.FindElement(By.Id("lblName")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Nuevo", driver.FindElement(By.Id("lblSurname")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("nuevo@gmail.com", driver.FindElement(By.Id("lblEmail")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("666346634", driver.FindElement(By.Id("lblPhone")).Text);
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
