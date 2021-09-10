using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FacebookAutomation.Login
{
    public class LoginPage
    {

        public static void FaceBookLogin(IWebDriver driver)
        {
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("7338846979");

            IWebElement password = driver.FindElement(By.Name("pass"));
            password.SendKeys("Vivek.13");

            IWebElement loginButton = driver.FindElement(By.Name("login"));
            loginButton.Click();
        }
    }
}
