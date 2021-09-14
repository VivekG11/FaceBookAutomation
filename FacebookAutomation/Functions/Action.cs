using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using FacebookAutomation.Login;

namespace FacebookAutomation.Functions
{
    public class Action
    {
        

       
        public static void AssertTitleAfterSearchingApplication(IWebDriver driver)
        {
            string title1 = "Facebook – log in or sign up";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {
          

            LoginPage login = new LoginPage(driver);

            login.email.SendKeys("7338846979");
            System.Threading.Thread.Sleep(9000);

            login.password.SendKeys("Vivek.13");

            login.confirm.Click();
            System.Threading.Thread.Sleep(6000);

            login.confirm.Click();
            System.Threading.Thread.Sleep(6000);

            login.loginButton.Click();
            System.Threading.Thread.Sleep(2000);

           /* profile.default_content_setting_values.notifications = 2

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); // to disable notification
            driver = new ChromeDriver(options);*/
        }


        public static void LoginUsingDataDrivenMethod(IWebDriver driver)
        {

            

            LoginUsingExcelData login1 = new LoginUsingExcelData(driver);
            login1.LoginToFacebook("login");

        }
    }
}
