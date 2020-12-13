using Internshiptask1.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Internshiptask1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifytheHomePageandProfilePage()
        {
            var HomeloginPage = new HomePage(driver);
            HomeloginPage.HomePagelogin();


            var detailsinprofilepage = new ProfilePage(driver);
            detailsinprofilepage.ProfilePagedetails();

        }
    }
}