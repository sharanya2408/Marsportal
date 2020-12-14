using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Speckflowtask1.StepDefinitoons
{
    [Binding]
    public  class VerifytheloginfunctionalityofMarsportal
    {
        IWebDriver driver;

        [BeforeScenario]
        void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Given(@"I navigate to the Mars portal")]
        public void GivenINavigateToTheMarsPortal()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
        }

        [When(@"I click on Sign in button and enter valid email id and password")]
        public void WhenIClickOnSignInButtonAndEnterValidEmailIdAndPassword()
        {
            driver.FindElement(By.CssSelector("a[class='item']")).Click();
            driver.FindElement(By.XPath("//*[@placeholder='Email address']")).SendKeys("katam.sharanya@gmail.com");
            driver.FindElement(By.XPath("//*[@placeholder='Password']")).SendKeys("sharanya24");
            
        }
        [Then(@"The user is able to click on Login button and loginto the portal")]
        public void ThenTheUserIsAbleToClickOnLoginButtonAndLogintoThePortal()
        {
            driver.FindElement(By.CssSelector("button.fluid.ui.teal.button")).Click();
            driver.Close();
        }

    }
}
