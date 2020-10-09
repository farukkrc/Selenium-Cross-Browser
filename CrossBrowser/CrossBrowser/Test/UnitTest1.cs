using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using CrossBrowser.Global;
using CrossBrowser.Pages;
namespace CrossBrowser
{
    [TestFixture]
    [Parallelizable]
    public class UnitTest1
    {
        Common locCommon = new Common();
        Login myLogin = new Login();

        [Test]
        public void ChromeMethod()
        {
            locCommon.BrowserDecision("Chrome");
            myLogin.Navigation(locCommon.driver);
            myLogin.Credentials(locCommon.driver);
            locCommon.EndTest();

        }
    }

    [TestFixture]
    [Parallelizable]
    public class UnitTest2
    {
        Common locCommon = new Common();
        Login myLogin = new Login();
        [Test]
        public void FirefoxMethod()
        {
            locCommon.BrowserDecision("Firefox");
            myLogin.Navigation(locCommon.driver);
            myLogin.Credentials(locCommon.driver);
            locCommon.EndTest();
        }
    }
}
