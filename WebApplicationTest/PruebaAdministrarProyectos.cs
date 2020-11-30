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
    //Creamos un proyecto, modificamos sus datos, creamos un nuevo rol, 
    //añadimos un usuario con ese rol y eliminamos el proyecto, comprobando 
    //en cada uno de los pasos toda la información
    [TestClass]
    public class PruebaAdministrarProyectos
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
        public void ThePruebaAdministrarProyectosTest()
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
            driver.FindElement(By.Id("ButtonCreateUser")).Click();
            driver.FindElement(By.Id("TextBoxName")).Click();
            driver.FindElement(By.Id("TextBoxName")).Clear();
            driver.FindElement(By.Id("TextBoxName")).SendKeys("ProyectoPrueba");
            driver.FindElement(By.Id("TextBoxMax")).Click();
            driver.FindElement(By.Id("TextBoxMax")).Clear();
            driver.FindElement(By.Id("TextBoxMax")).SendKeys("3");
            driver.FindElement(By.Id("TextBoxDescription")).Click();
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("Proyecto de prueba");
            driver.FindElement(By.Id("ButtonCreateNewProject")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProject"))).SelectByText("ProyectoPrueba");
            driver.FindElement(By.Id("ButtonShowData")).Click();
            try
            {
                Assert.AreEqual("ProyectoPrueba", driver.FindElement(By.Id("lblName")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("3", driver.FindElement(By.Id("lblMax")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonChangeDates")).Click();
            driver.FindElement(By.Id("DropProjects")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProjects"))).SelectByText("ProyectoPrueba");
            driver.FindElement(By.Id("TextBoxMax")).Click();
            driver.FindElement(By.Id("TextBoxMax")).Clear();
            driver.FindElement(By.Id("TextBoxMax")).SendKeys("5");
            driver.FindElement(By.Id("TextBoxDescription")).Click();
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("Nueva descripción");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProject"))).SelectByText("ProyectoPrueba");
            driver.FindElement(By.Id("ButtonShowData")).Click();
            try
            {
                Assert.AreEqual("5", driver.FindElement(By.Id("lblMax")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Nueva descripción", driver.FindElement(By.Id("lblDescription")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonAdminRoles")).Click();
            driver.FindElement(By.Id("Button1")).Click();
            driver.FindElement(By.Id("TextBoxName")).Click();
            driver.FindElement(By.Id("TextBoxName")).Clear();
            driver.FindElement(By.Id("TextBoxName")).SendKeys("RolPrueba");
            driver.FindElement(By.Id("TextBoxID")).Click();
            driver.FindElement(By.Id("TextBoxID")).Clear();
            driver.FindElement(By.Id("TextBoxID")).SendKeys("1");
            driver.FindElement(By.Id("TextBoxDescription")).Click();
            driver.FindElement(By.Id("TextBoxDescription")).Clear();
            driver.FindElement(By.Id("TextBoxDescription")).SendKeys("Prueba");
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("ButtonAddUserProject")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProjects"))).SelectByText("ProyectoPrueba");
            new SelectElement(driver.FindElement(By.Id("DropRol"))).SelectByText("RolPrueba");
            new SelectElement(driver.FindElement(By.Id("DropUsers"))).SelectByText("Carlos");
            driver.FindElement(By.Id("DropUsers")).Click();
            driver.FindElement(By.Id("DropRol")).Click();
            driver.FindElement(By.Id("DropRol")).Click();
            driver.FindElement(By.Id("ButtonAcept")).Click();
            driver.FindElement(By.Id("ButtonBack")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProject"))).SelectByText("ProyectoPrueba");
            driver.FindElement(By.Id("ButtonShowData")).Click();
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("DropUsers")).Text.Contains("Carlos"));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            new SelectElement(driver.FindElement(By.Id("DropUsers"))).SelectByText("Carlos");
            driver.FindElement(By.Id("ButtonRol")).Click();
            try
            {
                Assert.AreEqual("RolPrueba", driver.FindElement(By.Id("lblRol")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("ButtonDelete")).Click();
            new SelectElement(driver.FindElement(By.Id("DropProjects"))).SelectByText("ProyectoPrueba");
            driver.FindElement(By.Id("ButtonBack")).Click();
            driver.FindElement(By.Id("DropProject")).Click();
            try
            {
                Assert.AreEqual(null, driver.FindElement(By.Id("DropProject")).GetAttribute("ProyectoPrueba"));
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
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
