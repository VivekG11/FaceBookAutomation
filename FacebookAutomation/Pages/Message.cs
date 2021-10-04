using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace FacebookAutomation.Pages
{
    public class Message
    {
        public Message(IWebDriver driver)
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

        [FindsBy(How = How.XPath, Using = "//*[@aria-label ='Messenger'][@role='button']")]
        [CacheLookup]
        public IWebElement messengericon;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/a[1]")]
        [CacheLookup]
        public IWebElement friend;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label ='Message'][@class='notranslate _5rpu']")]
        [CacheLookup]
        public IWebElement text;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label ='Press Enter to send'][@role='button']")]
        [CacheLookup]
        public IWebElement send;
    }
}
