using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Radial.Greythr.SignOut
{
    [TestClass]
    public class Logout
    {
    
         String test_url = "http://radial.greythr.com/";
        // String itemName = "Yey, Let's add it to list";

        [TestMethod]
        public void GreythrLogOut()
        {
            IWebDriver Driver;

            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(test_url);

            Driver.Manage().Window.Maximize();
            // Driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
            Thread.Sleep(20000);
                IWebElement User = Driver.FindElement(By.XPath("//input[@id='username']"));
            IWebElement Pwd = Driver.FindElement(By.XPath("//input[@id='password']"));
            User.SendKeys("0062");
            Pwd.SendKeys("Aishu@18");

            IWebElement Login = Driver.FindElement(By.XPath("//h6[contains(text(),'Sign In')]"));

            Login.Click();

            Thread.Sleep(20000);

            IWebElement Attendance = Driver.FindElement(By.XPath("//body/div[2]/div[2]/div[2]/div[1]/div[1]/ul[1]/li[4]/a[1]"));

            Attendance.Click();
            Thread.Sleep(20000);

            IWebElement Signout = Driver.FindElement(By.XPath("//button[contains(text(),'Sign Out')]"));
            Signout.Click();

            Thread.Sleep(20000);
            Driver.Close();


        }
    }
}
