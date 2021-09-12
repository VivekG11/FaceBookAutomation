
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;



namespace FacebookAutomation.Registration
{
    public class SignUp
    {

        public static void UserRegistration(IWebDriver driver)
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



            IWebElement reg_email__ = driver.FindElement(By.Name("reg_email__"));
            reg_email__.SendKeys("vivekvk2903@gmail.com");
            System.Threading.Thread.Sleep(1000);



            IWebElement ReEnterEmail = driver.FindElement(By.Name("reg_email_confirmation__"));
            ReEnterEmail.SendKeys("vivekvk2903@gmail.com");
            System.Threading.Thread.Sleep(1000);



            driver.FindElement(By.Name("reg_passwd__")).SendKeys("Vivek@13");
            System.Threading.Thread.Sleep(1000);



            SelectElement element = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            element.SelectByText("11");
            System.Threading.Thread.Sleep(1000);



            SelectElement element1 = new SelectElement(driver.FindElement(By.Id("month")));
            element1.SelectByValue("6");
            System.Threading.Thread.Sleep(1000);



            SelectElement element2 = new SelectElement(driver.FindElement(By.Id("year")));
            element2.SelectByValue("1999");
            System.Threading.Thread.Sleep(1000);



            driver.FindElement(By.Name("sex")).Click();
            System.Threading.Thread.Sleep(1000);



            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(10000);



        }
    }
}

