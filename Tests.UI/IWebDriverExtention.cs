using OpenQA.Selenium;

namespace Tests.UI
{
    public static class IWebDriverExtention
    {
        public static void ScrollIntoView(this IWebDriver driver, IWebElement webElement)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView()", webElement);
        }

        public static void RemoveElementById(this IWebDriver driver, string id)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver; 
            js.ExecuteScript($"return document.getElementById('{id}').remove();");
        }
    }
}
