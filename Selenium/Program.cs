using System;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\giorn\Desktop\chrome");
            var login = new Login();
            var utilities = new Utilities();
            var updateButton = new UpdateButton();
            var clickable = new Clickable();

            var search = "cw-amazetravel-hour";
            var cronExpression = "0 0 0/2 1/1 * ? *";
            const string username = "#";
            const string password = "#";

            driver.Manage().Window.Maximize();

            login.LoginPage(driver, "https://app.linktou.com.br/integrator/login/");
            utilities.SendKeysByXpath(driver, "/html/body/div[1]/div/main/section/form/div[1]/div/input", username);
            utilities.SendKeysByXpath(driver, "/html/body/div[1]/div/main/section/form/div[2]/div/input", password);
            utilities.ClickByXpath(driver, "/html/body/div[1]/div/main/section/form/div[3]/button");

            utilities.ClickByXpath(driver, "/html/body/div[1]/div/div[2]/main/div/div/div[2]/table/tbody/tr[3]/td[1]/a");

            updateButton.ClickWebhookByXpath(driver, "/html/body/div[1]/div/div[2]/main/div[2]/div/div[1]/div[1]/div[1]/div[2]/div/button");
            utilities.ClickByXpath(driver, "/html/body/div[1]/div/div[2]/main/div[3]/div/div/div/div[1]/div/button");
            utilities.ClickById(driver, "tabItem-button-cron");
            utilities.SendKeysById(driver, "cronTrigger-input-cronExpression", cronExpression);

            //utilities.ClickByClass(driver, "view-lines");
            //clickable.SendKeysByXpath(driver, "view-lines", "{}");

            IWebDriver Amazon = new ChromeDriver(@"C:\Users\giorn\Desktop\chrome");
            Amazon.Manage().Window.Maximize();

            login.LoginPage(Amazon, "https://aws.amazon.com/pt/");
            utilities.ClickByXpath(Amazon, "/html/body/header/div[1]/div[1]/nav/div/div/div/div/div[1]/a");
            utilities.ClickById(Amazon, "aws-signin-general-user-selection-iam");
            utilities.SendKeysById(Amazon, "resolving_input", "#");
            utilities.ClickById(Amazon, "next_button");
            utilities.SendKeysById(Amazon, "username", "#");
            utilities.SendKeysById(Amazon, "password", "#");
            utilities.ClickById(Amazon, "signin_button");
            utilities.SendKeysByClass(Amazon, "globalNav-search-0419", "CloudWatch");
            utilities.ClickByXpath(Amazon, "/html/body/div[2]/div[1]/div/div[3]/div/header/nav/nav/div/div[2]/div/div[2]/div/div/div[2]/div/div[2]/ul/li[1]/div/div[1]/ol/li[1]/div/div[1]/div[2]/div/h3/a/span");
            utilities.ClickByXpath(Amazon, "/html/body/div[2]/div[2]/div/div[2]/div[2]/div/div[2]/div/div/div/nav/div/div[3]/ul/li[6]/div/div/div[1]/span");
            Thread.Sleep(2000);
            utilities.ClickByXpath(Amazon, "/html/body/div[2]/div[2]/div/div[2]/div[2]/div/div[2]/div/div/div/nav/div/div[3]/ul/li[6]/div/div/div[2]/ul/li[1]/span/a");
            utilities.ClickByXpath(Amazon, "/html/body/div[2]/div[2]/div/div[2]/div[2]/div/div[4]/div/div[3]/div/div[2]/div/div/div/div/div[2]/div[2]/button[1]");
            utilities.SendKeysById(Amazon, "awsui-input-0", search);
            utilities.ClickByXpath(Amazon, "/html/body/div[2]/div[2]/div/div[1]/div/awsui-app-layout/div/main/div/div[2]/div/span/div/div[2]/div/awsui-table/div/div[3]/table/tbody/tr[1]/td[2]/span/a");
            utilities.ClickById(Amazon, "rules-details-delete-rule");
            utilities.SendKeysByXpath(Amazon, "/html/body/div[5]/div/div[2]/div/div/div[2]/div/div/div[2]/div/div/div/div/div/input", "excluir");
            utilities.ClickByXpath(Amazon, "/html/body/div[5]/div/div[2]/div/div/div[3]/div/div/div[2]/button");

            Console.ReadKey();
        }
    }
}
