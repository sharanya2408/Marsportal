using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Speckflowtask1.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Speckflowtask1.StepDefinitoons
{
    [Binding]
    public  class VerifytheuserisabletoenterCertificationsdetails
    {


        IWebDriver driver;

        [BeforeScenario]
        void Setup()
        {
            driver = new ChromeDriver();

        }
        [Given(@"I login to the Mars portal using valid credentials")]
        public void GivenILoginToTheMarsPortalUsingValidCredentials()
        {
            var HomeloginPage = new HomePage(driver);
            HomeloginPage.Login();
        }


        [When(@"I navigate to certifications tab from educations tab and click on Add New button\.")]
        public void WhenINavigateToCertificationsTabFromEducationsTabAndClickOnAddNewButton_()
        {
            var languagedetails = new ProfilePage(driver);
            languagedetails.Languagedetails();

            var skilldetails = new ProfilePage(driver);
            skilldetails.Skillsdetails();

            var educatondetials = new ProfilePage(driver);
            educatondetials.Educationdetails();

            var CertificationADDNew = new ProfilePage(driver);
            CertificationADDNew.CertificationAddNew();
        }
        [When(@"I enter certificate, certificate from, year details and click on Add\.")]
        public void WhenIEnterCertificateCertificateFromYearDetailsAndClickOnAdd_()
        {
            var certificationdetails = new ProfilePage(driver);
            certificationdetails.Certificaitonsdetails();
        }
        [Then(@"The user is able to add certifications details and display on profile page\.")]
        public void ThenTheUserIsAbleToAddCertificationsDetailsAndDisplayOnProfilePage_()
        {
            driver.Quit();
        }

    }
}
