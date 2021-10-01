using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace FacebookAutomation.Logout
{
    public class logout
    {
        public logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        //[FindsBy(How = How.ClassName, Using = "_9lsa")]
        //public IWebElement confirm;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[1]/span[1]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement account;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Log Out')]")]
        [CacheLookup]
        public IWebElement logoutbtn;
    }
}
