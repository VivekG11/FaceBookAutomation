using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using FacebookAutomation.Login;
using FacebookAutomation.Registration;
using FacebookAutomation.UploadPhoto;
using AutoItX3Lib;

namespace FacebookAutomation.Functions
{
    public class UploadPhoto
    {
        public static void PostPhoto(IWebDriver driver)
        {
            //try
            //{
            //creating an instance of AutoItX3 class
            AutoItX3 autoIt = new AutoItX3();
            //creating an object of LoginPage class
            upload post = new upload(driver);

            post.email.SendKeys("ucs17139@rmd.ac.in");
            Thread.Sleep(5000);

            post.password.SendKeys("123456789ABCD");

            post.confirm.Click();
            Thread.Sleep(3000);

            post.confirm.Click();
            Thread.Sleep(3000);

            post.loginButton.Click();
            Thread.Sleep(3000);

            post.homeIcon.Click();
            Thread.Sleep(3000);

            post.createPost.Click();
            Thread.Sleep(3000);

            post.uploadPhoto.Click();
            Thread.Sleep(3000);

            post.addPhoto.Click();
            Thread.Sleep(3000);

            //using autoit to upload file 
            autoIt.WinActivate("Open");

            autoIt.Send(@"C:\Users\vivek.g\Pictures\Screenshots\Screenshot (2).png");
            Thread.Sleep(2000);

            autoIt.Send("{Enter}");

            post.post.Click();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
