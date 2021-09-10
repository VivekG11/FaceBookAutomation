using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FacebookAutomation.Login;
using FacebookAutomation.Registration;

namespace FacebookAutomation
{
    public class Tests:BaseClass.Base
    {
       

        [Test]
        public void AssertTitleAfterSearchingApplication()
        {
            string title1 = "Facebook – log in or sign up";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        [Test]
        public void LoginusingCredentials()
        {
            LoginPage.FaceBookLogin(driver);
        }

        [Test]
        public void NewRegistration()
        {
            SignUp.NewUserRegistration(driver);
        }


    }
}