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

        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div/a/div")]
        //[CacheLookup]
        //public IWebElement homeIcon;

        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[3]/div/div[2]/div/div/div/div[1]/div")]
        //[CacheLookup]
        //public IWebElement createPost;

        //[FindsBy(How = How.XPath, Using = "//*[@class='dwxx2s2f dicw6rsg kady6ibp rs0gx3tq'] [1]")]
        //[CacheLookup]
        //public IWebElement uploadPhoto;

        //[FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
        //[CacheLookup]
        //public IWebElement addPhoto;

        //[FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
        //[CacheLookup]
        //public IWebElement post;
    }
}
