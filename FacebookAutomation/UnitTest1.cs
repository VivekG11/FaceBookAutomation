using NUnit.Framework;
using FacebookAutomation.Registration;


namespace FacebookAutomation
{
    public class Tests:BaseClass.Base
    {

        [Test]
        public void NewRegistration()
        {
            SignUp.NewUserRegistration(driver);
        }

        [Test]
        public void LoginusingCredentials()
        {
           Functions.Action.AssertTitle(driver);
           Functions.Action.LoginToFacebook(driver);
        }

        [Test]
        public void FileUpload()
        {
            Functions.UploadPhoto.PostPhoto(driver);
        }
    }
}