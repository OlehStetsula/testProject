using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace SeleniumGridTests
{
    public class Tests
    {
        [Parallelizable]
        [Test]
        public void Test1()
        {
            FirefoxOptions options = new FirefoxOptions() { AcceptInsecureCertificates = true };
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            
            IWebDriver driver = new RemoteWebDriver(options);

            driver.Navigate().GoToUrl($"https://www.google.com.ua");
            Thread.Sleep(5000);
            driver.Quit();
        }

        [Parallelizable]
        [Test]
        public void Test3()
        {
            FirefoxOptions options = new FirefoxOptions() { AcceptInsecureCertificates = true };
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            IWebDriver driver = new RemoteWebDriver(options);

            driver.Navigate().GoToUrl($"https://www.facebook.com");
            Thread.Sleep(5000);
            driver.Quit();
        }

        [Parallelizable]
        [Test]
        public void Test2()
        {
            ChromeOptions options = new ChromeOptions();
            IWebDriver driver = new RemoteWebDriver(options);
            driver.Navigate().GoToUrl($"https://www.google.com.ua");
            Thread.Sleep(5000);
            driver.Quit();
        }

        //[Parallelizable]
        //[Test]
        public void Test4()
        {
            var options = new EdgeOptions();
            IWebDriver driver = new RemoteWebDriver(options.ToCapabilities());
            driver.Navigate().GoToUrl($"https://www.google.com.ua");
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}