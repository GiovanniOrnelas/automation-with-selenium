using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class Utilities
    {
        const int timeout = 10000;

        public void SendKeysById(IWebDriver driver, string path, string text)
        {
            driver.FindElement(By.Id(path), timeout).SendKeys(text);
        }

        public void SendKeysByClass(IWebDriver driver, string path, string text)
        {
            driver.FindElement(By.ClassName(path), timeout).SendKeys(text);
        }

        public virtual void SendKeysByXpath(IWebDriver driver, string path, string text)
        {
            driver.FindElement(By.XPath(path), timeout).SendKeys(text);
        }

        public void ClickById(IWebDriver driver, string path)
        {
            driver.FindElement(By.Id(path), timeout).Click();
        }

        public void ClickByClass(IWebDriver driver, string path)
        {
            driver.FindElement(By.ClassName(path), timeout).Click();
        }

        public void ClickByXpath(IWebDriver driver, string path)
        {
            driver.FindElement(By.XPath(path), timeout).Click();
        }
    }
}
