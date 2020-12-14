using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Speckflowtask1.PageObject
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Login()
        {
            //navigating to blazedemo
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //log into the mars portal
            driver.FindElement(By.CssSelector("a[class='item']")).Click();
            driver.FindElement(By.XPath("//*[@placeholder='Email address']")).SendKeys("katam.sharanya@gmail.com");
            driver.FindElement(By.XPath("//*[@placeholder='Password']")).SendKeys("sharanya24");
            driver.FindElement(By.CssSelector("button.fluid.ui.teal.button")).Click();

            //var x = driver.FindElement(By.LinkText("sharanya katam")).Text;
            //if(x == "sharanya katam")
            //{
            //    Console.WriteLine("successfull");
            //}
            //else
            //{
            //    Console.WriteLine("unsuccessful");
            //}
            //    var profilename = driver.FindElement(By.XPath("//*[@class='item ui dropdown link']")).Text;

            //    if (profilename == "Hi sharanya")
            //    {
            //        Console.WriteLine("authorised login");
            //    }
            //    else
            //    {
            //        Console.WriteLine("unauthorised login");
            //    }
        }

    }
}
