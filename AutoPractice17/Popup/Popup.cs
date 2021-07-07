using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutoPractice17.Popup
{
    public class Popup
    {
        private IWebDriver _driver;

        public Popup(IWebDriver driver)
        {
            _driver = driver;
        }

        public static By ContainerLocator = By.Id("image-darkener");

        public IWebElement CloseButton
            => _driver.FindElement(By.Id("at-cv-lightbox-close"));

        public void WaitForPopup()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(300),
            };

            wait.Until(ExpectedConditions.ElementIsVisible(ContainerLocator));
        }
    }
}
