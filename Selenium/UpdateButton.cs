using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class UpdateButton
    {
        public void ClickWebhookByClass(IWebDriver driver, string path)
        {
            driver.FindElement(By.ClassName(path), 10).Click();
        }
        public void ClickWebhookByXpath(IWebDriver driver, string path)
        {
            driver.FindElement(By.XPath(path), 10).Click();
        }
    }
}
