
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAutomation.Registration
{
    public  class SignUp
    {
        public static void NewUserRegistration(IWebDriver driver)
        {
            IWebElement createButton = driver.FindElement(By.XPath("//*[text()='Create New Account']"));
            createButton.Click();

            IWebElement firstName = driver.FindElement(By.Name("firstname"));
            firstName.SendKeys("Vivek");

            IWebElement lastName = driver.FindElement(By.Name("lastname"));
            lastName.SendKeys("g");

            IWebElement email = driver.FindElement(By.Name("reg_email__"));
            email.SendKeys("vivekguntuku11@gmail.com");

            IWebElement pwd = driver.FindElement(By.Name("reg_passwd__"));
            pwd.SendKeys("Vivek@73388");

           /* IWebElement element = driver.FindElement(By.Name("firstname"));
            var selectDate = new Se*/



        }
    }
}
