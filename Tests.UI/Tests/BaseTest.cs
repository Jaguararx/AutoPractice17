using Allure.Commons;
using Microsoft.Extensions.Configuration;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Tests.UI.Tests
{
    [AllureNUnit]
    public class BaseTest
    {
        public TestSettings settings { get; set; }
        public IWebDriver driver { get; set; }

        [OneTimeSetUp]
        public void SetUpBeforTestRun()
        {
            settings = new TestSettings();
            var configuration = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .AddJsonFile("appsettings.development.json", optional: true)
                                .Build();
            configuration.Bind(settings);

            var pathToDriver = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            var options = new ChromeOptions();
            if (settings.Headless)
            {
                options.AddArgument("headless");
            }

            driver = new ChromeDriver(pathToDriver, options);
//            driver = new RemoteWebDriver(new Uri("http://172.23.0.58:4444/wd/hub"), options);
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void TearDownBeforTestRun()
        {
            driver.Close();
            driver.Quit();
        }

        /// <summary>
        ///   Tear down method for Test Fixture. Implements Zephyr integration if enabled.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                //Add screenshot to Allure on Failure
                AllureLifecycle.Instance.AddAttachment($"Screenshot [{DateTime.Now:HH:mm:ss}]",
                "image/png",
                ss.AsByteArray);
                //Add page source to Allure in Failure
                AllureLifecycle.Instance.AddAttachment($"PageSource_{DateTime.Now:HH:mm:ss}",
                "text/html",
                Encoding.Unicode.GetBytes(driver.PageSource),
                ".html");
            }
        }
    }
}
