using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumClass
{
    public class AjaxHandling
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/ajax.html");

            driver.Manage().Window.Maximize();


            driver.FindElement(By.CssSelector(".container"));
            IWebElement noTextElement = driver.FindElement(By.ClassName("radiobutton"));
        String textBefore = noTextElement.Text.Trim();
            Console.WriteLine("The text before clicking the ajax element: " + textBefore);

             driver.FindElement(By.XPath("//input[@id='yes']")).Click();

            Thread.Sleep(2000);


            driver.FindElement(By.Id("buttoncheck")).Click();



            IWebElement textAfterAjaxCall = driver.FindElement(By.ClassName("radiobutton"));
            String textAfter = textAfterAjaxCall.Text;
            Console.WriteLine("The text after clicking the ajax element: " + textAfter);

            // before click: <p class="radiobutton"></p>
            // after click:  <p class="radiobutton">Radio button is checked and it's value is Yes</p>  
    }
    }
}
