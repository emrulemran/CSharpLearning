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
    public class AllOptionsDropDown
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/register.php");
            SelectElement dropDownMenu = new SelectElement(driver.FindElement(By.Name("country")));
            List<IWebElement> countries = new List<IWebElement>(dropDownMenu.Options);
            foreach (var country in countries)
            {
                Console.WriteLine(country.Text);
            }


        }
    }
}
