using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Support;
using SeleniumExtras.WaitHelpers;

namespace Selenium
{
    public class Clickable : Utilities
    {
        public override void SendKeysByXpath(IWebDriver driver, string path, string text)
        {
            var await = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

            await.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).SendKeys(text);
        }
    }
}
