using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumClass
{
    public class AlertsDemo
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/javascript_alerts");

            Thread.Sleep(2000);
            
            IWebElement button1 = driver.FindElement(By.XPath("//button[.='Click for JS Alert']"));
            button1.Click();
            Thread.Sleep(2000);
            Console.WriteLine("The first button clicked!");
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            Console.WriteLine("The alert has been clicked and accepted!");

            driver.Navigate().Refresh();

            Thread.Sleep(2000);
            IWebElement button2 = driver.FindElement(By.XPath("//button[.='Click for JS Confirm']"));
            button2.Click();
            Thread.Sleep(2000);
            Console.WriteLine("The second button clicked!");
            driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(2000);
            Console.WriteLine("The alert has been clicked and dismissed!");

            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            IWebElement button3 = driver.FindElement(By.XPath("//button[.='Click for JS Prompt']"));
            button3.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Entering the name: John");
            driver.SwitchTo().Alert().SendKeys("John");
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("The alert has been clicked, the name John entered and accepted!");

            Thread.Sleep(2000);
            driver.Quit();   
        }
    }
}
