using AutoPractice17.Main;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoPractice17
{
    public class MainPage : PageObjectBase
    {
        public MainPage(IWebDriver driver) : base(driver) {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "treemenu")]
        //[CacheLookup]
        public IWebElement menuList;

        public MenuList MenuList
        {
            get { return new MenuList(menuList); }
        }
    }
}
