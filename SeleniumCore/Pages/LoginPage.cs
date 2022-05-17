using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCore.Pages
{
     public class LoginPage
    {
        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }
        IWebElement txtUserName => Driver.FindElement(By.Name("User Name"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));

        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));
        
        public void Login(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }
    }
}
