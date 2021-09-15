using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace FacebookAutomation.Registration
{
    public class SignUp
    {
      

        public static void NewUserRegistration(IWebDriver driver)
        {
            

            IWebElement CreateButton = driver.FindElement(By.XPath("//*[text()='Create New Account']"));
            CreateButton.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement firstname = driver.FindElement(By.Name("firstname"));
            firstname.SendKeys("Vivek");
            System.Threading.Thread.Sleep(1000);

            IWebElement lastname = driver.FindElement(By.Name("lastname"));
            lastname.SendKeys("G");
            System.Threading.Thread.Sleep(1000);

            IWebElement email = driver.FindElement(By.Name("reg_email__"));
            email.SendKeys("vivekvk2903@gmail.com");
            System.Threading.Thread.Sleep(1000);

            IWebElement confirmEmail = driver.FindElement(By.Name("reg_email_confirmation__"));
            confirmEmail.SendKeys("vivekvk2903@gmail.com");
            System.Threading.Thread.Sleep(1000);

           IWebElement pwd = driver.FindElement(By.Name("reg_passwd__"));
            pwd.SendKeys("Vivek@3434");
            System.Threading.Thread.Sleep(1000);

            SelectElement date = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            date.SelectByText("29");
            System.Threading.Thread.Sleep(1000);

            SelectElement month = new SelectElement(driver.FindElement(By.Id("month")));
            month.SelectByValue("3");
            System.Threading.Thread.Sleep(1000);

            SelectElement year = new SelectElement(driver.FindElement(By.Id("year")));
            year.SelectByValue("2000");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.ClassName("_58mt")).Click();
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(10000);

        }
    }
}
