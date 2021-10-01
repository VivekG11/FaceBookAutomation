using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using FacebookAutomation.Login;
using FacebookAutomation.Registration;
using AutoItX3Lib;

namespace FacebookAutomation.Functions
{
    public class Login
    {
        public static IWebDriver driver { get; set; }
        //public static void AssertTitle(IWebDriver driver)
        //{
        //    string title1 = "Facebook – log in or sign up";
        //    string title = driver.Title;
        //    Assert.AreEqual(title1, title);
        //}
        public static void LoginToFacebook(IWebDriver driver)
        {
            try
            {
                //creating an object of LoginPage class
               LoginPage login = new LoginPage(driver);

               // driver.Url = "https://www.facebook.com/";

                login.email.SendKeys("ucs17139@rmd.ac.in");
                Thread.Sleep(2000);

                login.password.SendKeys("123456789ABCD");
                Thread.Sleep(2000);

                //login.confirm.Click();
                //Thread.Sleep(2000);

                login.loginButton.Click();
                Thread.Sleep(2000);

                //login.homeIcon.Click();
                //Thread.Sleep(2000);

                //login.logoutIcon.Click();
                //Thread.Sleep(2000);

                //login.logoutBtn.Click();
                //Thread.Sleep(2000);

                //login.profile.SendKeys(Keys.Enter);
                //Thread.Sleep(3000);

                //login.cam.SendKeys(Keys.Enter);
                //Thread.Sleep(2000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

}

      
    }
}
