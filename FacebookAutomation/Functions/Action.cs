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
        

       
        public static void AssertTitleAfterSearchingApplication(IWebDriver driver)
        {
            string title1 = "Facebook – log in or sign up";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LoginToFacebook(IWebDriver driver)
        {

            AutoItX3 autoIt = new AutoItX3();

            LoginPage login = new LoginPage(driver);

            login.email.SendKeys("7338846979");
            Thread.Sleep(5000);

            login.password.SendKeys("Vivek@3384");

            login.confirm.Click();
            Thread.Sleep(3000);

            login.confirm.Click();
            Thread.Sleep(3000);

            login.loginButton.Click();
            Thread.Sleep(2000);

            login.homeIcon.Click();
            Thread.Sleep(3000);

            login.createPost.Click();
            Thread.Sleep(3000);

            login.uploadPhoto.Click();
            Thread.Sleep(3000);

            login.addPhoto.Click();
            Thread.Sleep(3000);

            autoIt.WinActivate("Open");

            autoIt.Send(@"C:\Users\vivek.g\Pictures\Screenshots\Screenshot (2).png");

            Thread.Sleep(2000);

            autoIt.Send("{Enter}");

            login.post.Click();
        }

        public static void NewRegistration(IWebDriver driver)
        {
            SignUp sign = new SignUp(driver);

            sign.CreateButon.Click();

            sign.firstname.SendKeys("Vivek");

            sign.lastname.SendKeys("G");

            sign.email.SendKeys("vivekvk2903@gmail.com");

            sign.confirmEmail.SendKeys("vivekvk2903@gmail.com");

            sign.pwd.SendKeys("Vivek@3434");

            sign.date.S

            
        }
      
    }
}
