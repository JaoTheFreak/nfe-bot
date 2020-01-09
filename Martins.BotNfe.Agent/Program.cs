using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Martins.BotNfe.Agent
{
    class Program
    {
        static void Main(string[] args)
        {
            var browserDriverPath = "/home/joaomartins/Downloads/";

            var baseUrl = "https://www.fsist.com.br/";

            var nfe = "32191205570714000825550010061807591137555748";

            IWebDriver browser = new FirefoxDriver(browserDriverPath);

            browser.Navigate().GoToUrl(baseUrl);

            var nfeKeyField = browser.FindElement(By.Id("chave"));

            nfeKeyField.SendKeys(nfe);

            var nfeButtonQuery = browser.FindElement(By.Id("butconsulta"));

            nfeButtonQuery.Click();

            
        }


    }
}
