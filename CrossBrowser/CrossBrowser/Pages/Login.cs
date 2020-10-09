using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossBrowser.Global;
using System.Threading;

namespace CrossBrowser.Pages
{

    public class Login
    {
        
        public void Navigation(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.obilet.com/");
        }
        public void Credentials(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.LinkText("Üye Ol")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='E-posta Adresi']")).SendKeys("FarukX@hotmail.com");
            driver.FindElement(By.Name("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[@class='register register-button']")).Click();

        }
    }
}
