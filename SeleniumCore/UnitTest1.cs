using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCore
{
    public class Test
    {
       
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Browser driver
            IWebDriver webDriver = new ChromeDriver(@"D:\driver");
            //Navigate to site
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

            //Identify Login
            IWebElement InkLogin = webDriver.FindElement(By.LinkText("Login"));

            //operation
            InkLogin.Click();

            var txtUserName = webDriver.FindElement(By.Name("UserName"));
            Assert.That(txtUserName.Displayed, Is.True);

            txtUserName.SendKeys("admin");
            webDriver.FindElement(By.Name("Password")).SendKeys("password");
            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            var EmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));
            Assert.That(EmployeeDetails.Displayed, Is.True);
        }
    }
}