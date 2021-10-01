using NUnit.Framework;
using FacebookAutomation.Registration;
using FacebookAutomation.CrossBrowsers;


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
          // Functions.Action.AssertTitle(driver);
           Functions.Login.LoginToFacebook(driver);
        }

        [Test]
        public void FacebookLogout()
        {
            Functions.logoutActions.LogoutofFacebook(driver);
        }

        [Test]
        public void FileUpload()
        {
            Functions.UploadPhoto.PostPhoto(driver);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : CrossBrowsing
    {
        //it invokes chromeDriver 
        public ChromeTesting() : base(Browsers.Chrome)
        {
            Functions.Login.LoginToFacebook(driver);
        }

        [Test]
        public void ChromeTest()
        {
            
        }
    }

    [TestFixture]
    [Parallelizable]
    public class FireFoxTesting : CrossBrowsing
    {
        //It invokes firefox driver
        public FireFoxTesting() : base(Browsers.Firefox)
        {

        }

        [Test]
        public void FireFoxTest()
        {
            Functions.Login.LoginToFacebook(driver);
        }
    }

    //[TestFixture]
    //[Parallelizable]
    //public class IETesting : CrossBrowsing
    //{
    //    //it invokes Internet Explorer
    //    public IETesting() : base(Browsers.IE)
    //    {

    //    }

    //    [Test]
    //    public void IETest()
    //    {
    //        Functions.Action.LoginToFacebook(driver);
    //    }
    //}
}