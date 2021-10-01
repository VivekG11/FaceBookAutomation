using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using log4net.Repository;
using log4net;
using System;
using System.Reflection;
using System.IO;

namespace FacebookAutomation.BaseClass
{
    public class Base
    {
        //Initialising IWebDriver interface to access class and to upcast specific browsers
        public static IWebDriver driver;

        public static readonly ILog Logfile = LogManager.GetLogger(typeof(Tests));
        public static readonly ILoggerRepository loggerRepository = LogManager.GetRepository(Assembly.GetCallingAssembly());


        [SetUp]
        public void Setup()
        {
            var file = new FileInfo("log4net.config");

            //logging info into file using XML configurator
            log4net.Config.XmlConfigurator.Configure(loggerRepository, file);

            try
            {
                //Logging Process info into file
                Logfile.Info("Initializing SetUp");
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--disable-notifications");
                Logfile.Info("Disabling notifications");
                driver = new ChromeDriver(options);
                Logfile.Info("navigating control to chrome browser");

                driver.Manage().Window.Maximize();
                driver.Url = "https://www.facebook.com/";
                // Screenshot();
                Logfile.Debug("Navigating to corresponding URL");
            }
            catch (Exception e)
            {
                Logfile.Error(e.Message);
            }
        }
        //[TearDown]
        //public void  teardown()
        //{
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
        //    driver.Quit();
        //}
    }
}
