using AutoPractice17;
using AutoPractice17.Popup;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.UI.Tests
{
    [AllureSuite("UI Tests")]
    public class WebDriverTests : BaseTest
    {
        public MainPage MainPage { get; set; }
        public BookingMainPage BookingMainPage { get; set; }

        //[Category("UI")]
        //public void FirstUITest()
        //{
        //    MainPage = new MainPage(driver);

        //    driver.Navigate().GoToUrl(settings.HomeURL);

        //    Popup popup = new Popup(driver);
        //    popup.WaitForPopup();
        //    popup.CloseButton.Click();
        //    driver.ScrollIntoView(MainPage.menuList);
        //    driver.RemoveElementById("treemenu");
        //    MainPage.menuList.Click();
        //    MainPage.MenuList.Group[0].WebElement.Click();
        //    MainPage.MenuList.Group[0].Links[0].Click();
        //    MainPage.MenuList.Group[3].WebElement.Click();
        //    MainPage.MenuList.Group[3].Links[0].Click();

        //}

        //[Test]
        //[Category("UI")]
        //public void SecondUITest()
        //{
        //    driver.Navigate().GoToUrl(settings.HomeURL);

        //    BookingMainPage = new BookingMainPage(driver);

        //    BookingMainPage.languageSwitch.Click();

        //    BookingMainPage.languageEnglish.Click();
        //}

        [Test]
        [Category("UI")]
        public void ThirdUITest()
        {
            driver.Navigate().GoToUrl(settings.HomeURL);

            Assert.AreEqual(driver.Title, "COE Test Automation Sample App");


        }
    }
}
