using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossBrowser.Global
{
    class Common : GlobalDriver
    {
        GlobalDriver gloDriver = new GlobalDriver();

        public void BrowserDecision(string browser)
        {
            if (browser == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "Firefox")
            {
                driver = new FirefoxDriver();
            }

        }
        public void EndTest()
        {
            driver.Close();
        }
    }
}
