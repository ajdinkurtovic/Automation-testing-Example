using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCore.Pages
{
    class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }
        public IWebElement Login => Driver.FindElement(By.LinkText("Login"));
         IWebElement EmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => Login.Click();

        public bool IsEDExist() => EmployeeDetails.Displayed;
    }
}
