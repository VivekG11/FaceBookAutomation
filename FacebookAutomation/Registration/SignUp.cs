
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace FacebookAutomation.Registration
{
    public class SignUp
    {  
        public static void NewUserRegistration(IWebDriver driver)
        {
            try
            {
                //Using IWebelement class to define web elements
                IWebElement CreateButton = driver.FindElement(By.XPath("//*[text()='Create New Account']"));
                CreateButton.Click();
                Thread.Sleep(1000);

                IWebElement firstname = driver.FindElement(By.Name("firstname"));
                firstname.SendKeys("Vivek");
                Thread.Sleep(1000);

                IWebElement lastname = driver.FindElement(By.Name("lastname"));
                lastname.SendKeys("G");
                Thread.Sleep(1000);

                IWebElement email = driver.FindElement(By.Name("reg_email__"));
                email.SendKeys("vivekvk2903@gmail.com");
                Thread.Sleep(1000);

                IWebElement confirmEmail = driver.FindElement(By.Name("reg_email_confirmation__"));
                confirmEmail.SendKeys("vivekvk2903@gmail.com");
                Thread.Sleep(1000);

                IWebElement pwd = driver.FindElement(By.Name("reg_passwd__"));
                pwd.SendKeys("Vivek@3434");
                Thread.Sleep(1000);

                SelectElement date = new SelectElement(driver.FindElement(By.Name("birthday_day")));
                date.SelectByText("29");
                Thread.Sleep(1000);

                SelectElement month = new SelectElement(driver.FindElement(By.Id("month")));
                month.SelectByValue("3");
                Thread.Sleep(1000);

                SelectElement year = new SelectElement(driver.FindElement(By.Id("year")));
                year.SelectByValue("2000");
                Thread.Sleep(1000);

                driver.FindElement(By.ClassName("_58mt")).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.Name("websubmit")).Click();
                Thread.Sleep(10000);
            }
            catch(System.Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
