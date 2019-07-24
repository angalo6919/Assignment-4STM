using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4_SystemTest
{
    [TestFixture]
    public class AllfieldmandatoryInputMerAlfaRomeo4CCoupe2018ExpectedNavigateToJDPowerAlfaRomeo4CCoupe2018
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
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
        public void TheAllfieldmandatoryInputMerAlfaRomeo4CCoupe2018ExpectedNavigateToJDPowerAlfaRomeo4CCoupe2018Test()
        {
            driver.Navigate().GoToUrl("http://localhost/assignment4/SENG8040TestHome.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search car details'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("sname")).Click();
            driver.FindElement(By.Name("sname")).Clear();
            driver.FindElement(By.Name("sname")).SendKeys("Angalo");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("7 Knack Lane");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Cambridge");
            driver.FindElement(By.Name("phNum")).Clear();
            driver.FindElement(By.Name("phNum")).SendKeys("519-577-7749");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("angalo.ca@outlook.com");
            driver.FindElement(By.Name("make")).Clear();
            driver.FindElement(By.Name("make")).SendKeys("Alfa Romeo");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("4C Coupe");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("View more about the vehicle")).Click();
            Assert.AreEqual("2018 ALFA ROMEO 4C COUPE RATINGS AND REVIEWS", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h1[1]")).Text);
        }
        [Test]
        public void TheInvalid10DigitPhoneNumberInput5195777749ExpectedPhoneNumberInputFieldCannotacceptInvalidPhoneNUmberFormatTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment4/SENG8040TestHome.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search car details'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("sname")).Click();
            driver.FindElement(By.Name("sname")).Clear();
            driver.FindElement(By.Name("sname")).SendKeys("Simon");
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("203-301 Traynor Avenue");
            driver.FindElement(By.Name("city")).Click();
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Cambridge");
            driver.FindElement(By.Name("phNum")).Clear();
            driver.FindElement(By.Name("phNum")).SendKeys("5195777749");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("simon@gmail.com");
            driver.FindElement(By.Name("make")).Clear();
            driver.FindElement(By.Name("make")).SendKeys("Mercedes Benz");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("S Class");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.Name("phNum")).Click();
            driver.FindElement(By.Name("phNum")).Click();
            driver.FindElement(By.Name("phNum")).Clear();
            driver.FindElement(By.Name("phNum")).SendKeys("519-577-7749");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual("519-577-7749", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Phone Number ='])[1]/following::label[1]")).Text);
        }
        [Test]
        public void TheInvalidDataBehaviourInputInvalidJDdataExpectedJDPower404Test()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment4/SENG8040TestHome.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search car details'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("sname")).Click();
            driver.FindElement(By.Name("sname")).Clear();
            driver.FindElement(By.Name("sname")).SendKeys("Moly Simon");
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("S N Park");
            driver.FindElement(By.Name("city")).Click();
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Thrissur");
            driver.FindElement(By.Name("phNum")).Click();
            driver.FindElement(By.Name("phNum")).Clear();
            driver.FindElement(By.Name("phNum")).SendKeys("949-555-7749");
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("molysimon@outlook.com");
            driver.FindElement(By.Name("make")).Click();
            driver.FindElement(By.Name("make")).Clear();
            driver.FindElement(By.Name("make")).SendKeys("Maruthi");
            driver.FindElement(By.Name("model")).Click();
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("800");
            driver.FindElement(By.Name("year")).Click();
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("1988");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.LinkText("View more about the vehicle")).Click();
            Assert.AreEqual("404 - NOT FOUND", driver.FindElement(By.XPath("//h1")).Text);
        }
        [Test]
        public void TheAllFieldMandatoryInputNoDataInFieldsandSubmitExpectedNullValuesNotAcceptedFieldsTurnRedTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment4/SENG8040TestHome.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search car details'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.Name("sname")).Clear();
            driver.FindElement(By.Name("sname")).SendKeys("God");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("666 Heaven");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Universe");
            driver.FindElement(By.Name("phNum")).Clear();
            driver.FindElement(By.Name("phNum")).SendKeys("666-666-6666");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("god666@heaven.com");
            driver.FindElement(By.Name("make")).Clear();
            driver.FindElement(By.Name("make")).SendKeys("Ford");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("Fusion");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2018");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual("God", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Seller Name ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("666 Heaven", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Address ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("Universe", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='City ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("666-666-6666", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Phone Number ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("god666@heaven.com", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Email ID ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("Ford", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Make ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("Fusion", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Model ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("2018", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year ='])[1]/following::label[1]")).Text);
            Assert.AreEqual("View more about the vehicle", driver.FindElement(By.LinkText("View more about the vehicle")).Text);
        }
        [Test]
        public void TheInvalidYearInput20252ExpectedNotAcceptedFieldRedTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment4/SENG8040TestHome.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search car details'])[1]/preceding::button[1]")).Click();
            driver.FindElement(By.Name("sname")).Click();
            driver.FindElement(By.Name("sname")).Clear();
            driver.FindElement(By.Name("sname")).SendKeys("Joseph");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("Changan House");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Thrissur");
            driver.FindElement(By.Name("phNum")).Clear();
            driver.FindElement(By.Name("phNum")).SendKeys("555-666-6698");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("joseph@gmail.com");
            driver.FindElement(By.Name("make")).Clear();
            driver.FindElement(By.Name("make")).SendKeys("Ford");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("Fusion");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("20252");
            driver.FindElement(By.Name("submit")).Click();
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2012");
            driver.FindElement(By.Name("submit")).Click();
            Assert.AreEqual("2012", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year ='])[1]/following::label[1]")).Text);
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


