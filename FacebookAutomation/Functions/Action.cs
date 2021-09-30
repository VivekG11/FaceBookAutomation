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
    public class Action
    {
        public static void AssertTitle(IWebDriver driver)
        {
            string title1 = "Facebook – log in or sign up";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {
            //try
            //{
                //creating an instance of AutoItX3 class
               AutoItX3 autoIt = new AutoItX3();
                //creating an object of LoginPage class
               LoginPage login = new LoginPage(driver);

                login.email.SendKeys("7338846979");
                Thread.Sleep(5000);

                login.password.SendKeys("Vivek@TVS");

                login.confirm.Click();
                Thread.Sleep(3000);

                login.loginButton.Click();
                Thread.Sleep(3000);

                //login.homeIcon.Click();
                //Thread.Sleep(3000);

                //login.createPost.Click();
                //Thread.Sleep(3000);

                //login.uploadPhoto.Click();
                //Thread.Sleep(3000);

                //login.addPhoto.Click();
                //Thread.Sleep(3000);

                ////using autoit to upload file 
                //autoIt.WinActivate("Open");

                //autoIt.Send(@"C:\Users\vivek.g\Pictures\Screenshots\Screenshot (2).png");
                //Thread.Sleep(2000);

                //autoIt.Send("{Enter}");

                //login.post.Click();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

      
    }
}
