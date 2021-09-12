using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace FacebookAutomation.BaseClass
{
    public class Base
    {
        //Initialising IWebDriver interface to access class and to upcast specific browsers
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url= "https://www.facebook.com/";
        }
      /*  [TearDown]
        public void  teardown()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
            driver.Quit();
        }*/
    }
}
