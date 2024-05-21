using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Project.Tests.Methods
{
    public class Driver
    {
        public IWebDriver driver;
        public StringBuilder verificationErrors;

        public Driver()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

    }
    public class Intialise
    {
        public static void SeleniumSetup()
        {
            try
            {
                Console.WriteLine("Starting Driver...........");

                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("https://demoqa.com/");
                driver.Manage().Window.Maximize();

                driver.FindElement(By.XPath("//*[@id=\"app\"]/header/a/img"));
            } 
            catch (Exception e) 
            {
                Console.WriteLine("Error Starting Web Driver...........");
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}