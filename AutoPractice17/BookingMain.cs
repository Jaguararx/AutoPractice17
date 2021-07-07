using AutoPractice17.Main;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoPractice17
{
    public class BookingMainPage : PageObjectBase
    {
        public BookingMainPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }



        [FindsBy(How = How.XPath, Using = "//img[starts-with(@class,'Avatar-module__image')]")]
        public IWebElement languageSwitch;

        [FindsBy(How = How.XPath, Using = "//img[contains(@src,'us.png')]")]
        public IWebElement languageEnglish;
    }
}
