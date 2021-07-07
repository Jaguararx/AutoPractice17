using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace AutoPractice17.Main
{
    public class MenuGroup
    {
        public IWebElement WebElement;

        public MenuGroup(IWebElement webElement)
        {
            WebElement = webElement;
            PageFactory.InitElements(this, new DefaultElementLocator(webElement));
        }

        [FindsBy(How = How.XPath, Using = ".//li/a")]
        public IList<IWebElement> Links;

    }
}
