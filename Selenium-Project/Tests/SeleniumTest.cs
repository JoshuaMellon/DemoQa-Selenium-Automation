using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V122.DOMSnapshot;
using Selenium_Project.Tests.Methods;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;

namespace Selenium_Project.Tests
{
    [TestFixture]
    public class Tests : Driver
    { 
        [SetUp]
        public void Setup()
        {
            Intialise.SeleniumSetup();
        }

        [Test]
        public void OpenSite()
        {
            
            driver.FindElement(By.XPath("//*[@id=\"app\"]/header/a"));

            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}