using NUnit.Framework;
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

        }

        [Test]
        public void NewRegistration()
        {

            SignUp.NewUserRegistration(driver);
        }


    }
}