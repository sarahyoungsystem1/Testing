using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\drivers\");
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.google.com";

            // type | id=lst-ib | pluralsight
            driver.FindElement(By.Id("lst-ib")).Clear();
            driver.FindElement(By.Id("lst-ib")).SendKeys("pluralsight");
            // click | id=_lsb | 
            driver.FindElement(By.ClassName("lsb")).Click();
            // click | link=Images | 
            driver.FindElement(By.LinkText("Images")).Click();
        }
    }
}
