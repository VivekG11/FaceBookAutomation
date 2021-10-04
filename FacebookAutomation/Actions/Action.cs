using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.PageObjects;
using FacebookAutomation.Login;
using AutoItX3Lib;
using FacebookAutomation.Logout;
using FacebookAutomation.UploadPhoto;
using FacebookAutomation.Pages;
using FacebookAutomation.DataAccess;
using System.Net.Mail;
using System.Net;

namespace FacebookAutomation.Functions
{
    public class Login : BaseClass.Base
    {
        public static IWebDriver driver { get; set; }

        public static void LoginToFacebook(IWebDriver driver)
        {
            try
            {
               //creating an object of LoginPage class
               LoginPage login = new LoginPage(driver);

                // driver.Url = "https://www.facebook.com/";

                Logfile.Info("Facebook Login in Page");

                Assert.AreEqual("Facebook – log in or sign up", driver.Title);

                login.email.SendKeys("7338846979");
                Thread.Sleep(2000);

                login.password.SendKeys("Vivek@1234");
                Thread.Sleep(2000);

                login.confirm.Click();
                Thread.Sleep(1000);

                Logfile.Info("Verifying the password");

                login.confirm.Click();
                Thread.Sleep(1000);

                login.loginButton.Click();
                Thread.Sleep(2000);

                Logfile.Debug("Login Succesfull and control navigating to HomePage");

                if(driver.Url != "https://www.facebook.com/?sk=welcome")
                {
                    BaseClass.Base.Screenshot();
                }
                else
                {
                    Assert.AreEqual("https://www.facebook.com/?sk=welcome", driver.Url);
                }
               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void LoginUsingExcelData(IWebDriver driver)
        {
            LoginPage login = new LoginPage(driver);

            Logfile.Info("Facebook Login in Page");

            Assert.AreEqual("Facebook – log in or sign up", driver.Title);

            AccessExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\DataResource\LoginData.xlsx");

            login.email.SendKeys(AccessExcelData.ReadData(1, "UserName"));
            Thread.Sleep(2000);

            login.password.SendKeys(AccessExcelData.ReadData(1, "Password"));
            Thread.Sleep(2000);

            login.confirm.Click();
            Thread.Sleep(1000);

            Logfile.Info("Verifying the password");

            login.confirm.Click();
            Thread.Sleep(1000);

            login.loginButton.Click();
            Thread.Sleep(2000);

            Logfile.Debug("Login Succesfull and control navigating to HomePage");

            if (driver.Url != "https://www.facebook.com/?sk=welcome")
            {
                BaseClass.Base.Screenshot();
            }
            else
            {
                Assert.AreEqual("https://www.facebook.com/?sk=welcome", driver.Url);
            }
        }


        public static void PostPhoto(IWebDriver driver)
        {
            try
            {

                Logfile.Info("Invoking AutoIt");
                //creating an instance of AutoItX3 class
                AutoItX3 autoIt = new AutoItX3();
                //creating an object of LoginPage class
                upload post = new upload(driver);

                Assert.AreEqual("Facebook – log in or sign up", driver.Title);

                post.email.SendKeys("7338846979");
                Thread.Sleep(5000);

                post.password.SendKeys("Vivek@TVS");

                post.confirm.Click();
                Thread.Sleep(3000);

                post.confirm.Click();
                Thread.Sleep(3000);

                post.loginButton.Click();
                Thread.Sleep(3000);

                Logfile.Debug("Login Succesfull and control navigating to HomePage");

                Assert.AreEqual("https://www.facebook.com/", driver.Url);

                post.homeIcon.Click();
                Thread.Sleep(4000);

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

                Logfile.Info("Photo posted Succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Messaging(IWebDriver driver)
        {
            Message msg = new Message(driver);

            LoginUsingExcelData(driver);

            msg.messengericon.Click();
            Thread.Sleep(3000);

            msg.friend.Click();
            Thread.Sleep(2000);

            msg.text.SendKeys(Keys.NumberPad2);
            Thread.Sleep(2000);

            msg.send.Click();

            Logfile.Info("Message sent Succesfully");
        }

        public static void MailReport(IWebDriver driver)
        {

            AccessExcelData.PopulateInCollection(@"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\DataResource\LoginData.xlsx");

            MailMessage mail = new MailMessage();
            Thread.Sleep(3000);

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            Thread.Sleep(2000);

            mail.From = new MailAddress(AccessExcelData.ReadData(2, "UserName"));
            Thread.Sleep(2000);

            mail.To.Add(AccessExcelData.ReadData(2, "Receipent"));
            Thread.Sleep(2000);

            mail.Subject = "Spotify TestCase Report";

            Attachment attachment = new Attachment(@"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\Report\index.html");
            Assert.NotNull(attachment);

            mail.Attachments.Add(attachment);
            client.Port = 587;

            client.Credentials = new NetworkCredential(AccessExcelData.ReadData(2, "UserName"), AccessExcelData.ReadData(2, "Password"));
            client.EnableSsl = true;
            Thread.Sleep(2000);

            client.Send(mail);
        }

        public static void LogoutofFacebook(IWebDriver driver)

        {
            try
            {
                //creating an object of LoginPage class
                logout signout = new logout(driver);

                LoginUsingExcelData(driver);

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
