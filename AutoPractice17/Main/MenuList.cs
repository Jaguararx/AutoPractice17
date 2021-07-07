using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace AutoPractice17.Main
{
    public class MenuList
    {
        public IWebElement WebElement;


        public MenuList(IWebElement webElement)
        {
            WebElement = webElement;
            PageFactory.InitElements(this, new DefaultElementLocator(webElement));
        }

        [FindsBy(How = How.XPath, Using = ".//ul/li[not(@style='display: none;')]")]
        private IList<IWebElement> group;

        private List<MenuGroup> _group;
        public List<MenuGroup> Group
        {
            get
            {
                if (_group==null)
                {
                    _group = new List<MenuGroup>();
                    foreach (var p in group)
                    {
                        _group.Add(new MenuGroup(p));
                    }

                }

                return _group;
            }
        }
    }
}
