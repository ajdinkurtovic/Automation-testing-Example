using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCore.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCore.Tests
{
    class LoginTest
    {
            //Browser driver
            IWebDriver webDriver = new ChromeDriver(@"D:\driver");

        [SetUp]
        public void Setup()
        {
            //Navigate to site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("admin", "password");

            Assert.That(homePage.IsEDExist, Is.True);
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}
