
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

        [BeforeScenario]
         void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Given(@"I login to the portal using valid credentials")]
        public void GivenILoginToThePortalUsingValidCredentials()
        {
            var HomeloginPage = new HomePage(driver);
            HomeloginPage.Login();
        }
        [When(@"I click on Add New button in language tab and enter language, language level details and click on Add")]
        public void WhenIClickOnAddNewButtonInLanguageTabAndEnterLanguageLanguageLevelDetailsAndClickOnAdd()
        {
            var languagedetails = new ProfilePage(driver);
            languagedetails.Languagedetails();
        }
        [Then(@"The user is able to add language details and navigate to skills tab")]
        public void ThenTheUserIsAbleToAddLanguageDetailsAndNavigateToSkillsTab()
        {
            driver.FindElement(By.XPath("//*[text()='Skills']")).Click();
            driver.Close();
        }



    }
}
