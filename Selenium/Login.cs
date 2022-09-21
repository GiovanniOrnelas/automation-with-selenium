using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class Login
    {
        public void LoginPage(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
