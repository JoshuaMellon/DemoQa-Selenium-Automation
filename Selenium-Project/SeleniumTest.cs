using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Selenium_Project
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OpenSite()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");

            driver.FindElement(By.XPath("//*[@id=\"app\"]/header/a/img"));

            driver.Quit();

            Assert.Pass();
        }
    }
}