using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V122.DOMSnapshot;
using Selenium_Project.Tests.Methods;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;

namespace Selenium_Project.Tests
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup(Intialise intialise)
        {
            intialise.SeleniumSetup();
        }

        [Test]
        public void OpenSite()
        {
            
            driver.FindElement(By.XPath("//*[@id=\"app\"]/header/a/img"));

            driver.Quit();

            Assert.Pass();
        }
    }
}