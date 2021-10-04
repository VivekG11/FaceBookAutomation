using NUnit.Framework;
using FacebookAutomation.Registration;
using FacebookAutomation.CrossBrowsers;
using AventStack.ExtentReports;
using FacebookAutomation.Functions;


namespace FacebookAutomation
{
    public class Tests:BaseClass.Base
    {
        ExtentReports reports = Report.report();
        ExtentTest test;

        [Test]
        public void NewRegistration()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating New user Registration in Facebook");
            SignUp.NewUserRegistration(driver);
            test.Log(Status.Pass, "TestCase passes");
            reports.Flush();
        }

        [Test]
        public void LoginusingCredentials()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating Facebook Login Page");
            Functions.Login.LoginUsingExcelData(driver);
            test.Info("Details", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\Screenshots\img1.jpg").Build());

            test.Log(Status.Pass, "TestCase passes");
            reports.Flush();
        }

        [Test]
        public void Login()
        {
            Functions.Login.LoginUsingExcelData(driver);
        }

        [Test]
        public void FileUpload()
        {
            Functions.Login.PostPhoto(driver);
        }

        [Test]
        public void Mail()
        {
            Functions.Login.MailReport(driver);
        }

        [Test]
        public void SendMessage()
        {
            Functions.Login.Messaging(driver);
        }
        [Test]
        public void FacebookLogout()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automating Facebook Login Page");
            Functions.Login.LogoutofFacebook(driver);
            test.Log(Status.Pass, "TestCase passes");
            reports.Flush();
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