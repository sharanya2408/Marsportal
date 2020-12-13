using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Speckflowtask1.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Speckflowtask1.StepDefinitoons
{
    [Binding]
    public  class VerifytheuserisabletoaddLanguagedetails
    {
        IWebDriver driver;
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Given(@"I login to the portal using valid credentials")]
        public void GivenILoginToThePortalUsingValidCredentials()
        {
            var HomeloginPage = new HomePage(driver);
            HomeloginPage.HomePagelogin();
        }
        [When(@"I click on Add New button in language tab and enter language, language level details and click on Add")]
        public void WhenIClickOnAddNewButtonInLanguageTabAndEnterLanguageLanguageLevelDetailsAndClickOnAdd()
        {
            driver.FindElement(By.XPath("//*[text()='Add New']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@name='name']")).SendKeys("Telugu");
            driver.FindElement(By.CssSelector("select.ui.dropdown")).Click();
            driver.FindElement(By.XPath("//*[@value='Native/Bilingual']")).Click();
            driver.FindElement(By.XPath("//*[@value='Add']")).Click();
        }
        [Then(@"The user is able to add language details and navigate to skills tab")]
        public void ThenTheUserIsAbleToAddLanguageDetailsAndNavigateToSkillsTab()
        {
            driver.FindElement(By.XPath("//*[text()='Skills']")).Click();
            driver.Close();
        }



    }
}
