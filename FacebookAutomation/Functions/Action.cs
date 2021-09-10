﻿using System;
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

            login.loginButton.Click();
            System.Threading.Thread.Sleep(9000);
        }
    }
}
