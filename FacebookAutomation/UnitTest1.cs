using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using FacebookAutomation.Login;
using FacebookAutomation.Registration;


namespace FacebookAutomation
{
    public class Tests:BaseClass.Base
    {


        [Test]
        public void LoginusingCredentials()
        {
           Functions.Action.AssertTitleAfterSearchingApplication(driver);

            Functions.Action.LoginToFacebook(driver);

           // Functions.Action.LoginUsingDataDrivenMethod(driver);
           
        }

        [Test]
        public void NewRegistration()
        {
          

           Registration.SignUp.UserRegistration(driver);
        }


    }
}