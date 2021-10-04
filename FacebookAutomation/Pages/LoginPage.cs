﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using AutoItX3Lib;


namespace FacebookAutomation.Login
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.ClassName, Using = "_9lsa")]
        public IWebElement confirm;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginButton;
    }
}