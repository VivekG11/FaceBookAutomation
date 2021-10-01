using OpenQA.Selenium;
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

        //[FindsBy(How = How.ClassName, Using = "_9lsa")]
        //public IWebElement confirm;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginButton;

        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        //[CacheLookup]
        //public IWebElement homeIcon;

        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        //[CacheLookup]
        //public IWebElement homeIcon;

        //[FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv i09qtzwb n7fi1qx3 b5wmifdl hzruof5a pmk7jnqg j9ispegn kr520xx4 c5ndavph art1omkt ot9fgl3s rnr61an3']")]
        //[CacheLookup]
        //public IWebElement logoutIcon;

        //[FindsBy(How = How.XPath, Using = "//span[contains(text(),'Log Out')]")]
        //[CacheLookup]
        //public IWebElement logoutBtn;

        //[FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]")]
        //[CacheLookup]
        //public IWebElement profile;

        //[FindsBy(How = How.ClassName, Using = "spb7xbtv bkmhp75w emlxlaya s45kfl79 cwj9ozl2 kr520xx4 j9ispegn pmk7jnqg n7fi1qx3 rq0escxv i09qtzwb")]
        //[CacheLookup]
        //public IWebElement cam;

    }
}
