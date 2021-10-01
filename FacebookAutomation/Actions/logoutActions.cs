using System;
using System.Collections.Generic;
using System.Text;
using FacebookAutomation.Logout;
using System.Threading;
using OpenQA.Selenium;

namespace FacebookAutomation.Functions
{
    class logoutActions
    {
        public static void LogoutofFacebook(IWebDriver driver)
        {
            try
            {
                //creating an object of LoginPage class
                logout signout = new logout(driver);

                // driver.Url = "https://www.facebook.com/";

                signout.email.SendKeys("7338846979");
                Thread.Sleep(2000);

                signout.password.SendKeys("Vivek@TVS");
                Thread.Sleep(2000);

                //login.confirm.Click();
                //Thread.Sleep(2000);

                signout.loginButton.Click();
                Thread.Sleep(2000);

                signout.account.Click();
                Thread.Sleep(2000);

                signout.logoutbtn.Click();
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
