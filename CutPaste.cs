using System;
using System.Threading;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumClass
{
    public class CutAndPasteToAnotherTextField
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/register.php");

            IWebElement fName = driver.FindElement(By.Name("firstName"));
            IWebElement lName = driver.FindElement(By.Name("lastName"));

            Actions act = new Actions(driver);
            act.SendKeys(fName, "Jamel").Build().Perform();

            act
                .KeyDown(Keys.Shift)
                .SendKeys(Keys.ArrowLeft)
                .SendKeys(Keys.ArrowLeft)
                .SendKeys(Keys.ArrowLeft)
                .SendKeys(Keys.ArrowLeft)
                .SendKeys(Keys.ArrowLeft)
                .SendKeys(Keys.ArrowLeft)
                .KeyUp(Keys.Shift)
                .KeyDown(Keys.Control)
                .SendKeys("x")
                .SendKeys(lName, "v")
                .KeyUp(Keys.Control).Build().Perform();


            // here are 4 lines of code
            int x = 12;
            string name = "nyc";
            char c = 'z';
            bool isRaining = false;
        }
    }
}
