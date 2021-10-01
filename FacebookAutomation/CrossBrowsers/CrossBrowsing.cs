using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using NUnit.Framework;

namespace FacebookAutomation.CrossBrowsers
{
    public enum Browsers
    {
        Chrome, Firefox, IE
    }
    public  class CrossBrowsing : Functions.Login
    {
        private Browsers browserType;

        //Creating constructor of class with Browsers as paramter
        public CrossBrowsing(Browsers browser)
        {
            browserType = browser;
        }

        [SetUp]
        public void TestSetup()
        {
            SelectBrowser(browserType);
        }

        public void SelectBrowser(Browsers driverType)
        {
            if (driverType == Browsers.Chrome)
                driver = new ChromeDriver();
            else if (driverType == Browsers.Firefox)
                driver = new FirefoxDriver();
            else driver = new InternetExplorerDriver();
        }
    }
}
