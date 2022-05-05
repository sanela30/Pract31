using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;



namespace Pract31.PageObjects
{
    internal class HomePage
    {
        private IWebDriver driver1;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver1 = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void GoToPage()
        {
            driver1.Navigate().GoToUrl("https://www.google.com/");
        }

        public IWebElement searchField
        {
            get
            {
                IWebElement element;
                try
                {
                    element = this.driver1.FindElement(By.Name("q"));
                }
                catch (Exception)
                {
                    element = null;
                }
                return element;
            }
        }
        public void SearchFor(string search)
        {
            this.searchField?.SendKeys(search);
            this.searchField?.Submit();
            wait.Until(EC.ElementIsVisible(By.Id("result-stats")));
        }
    }
}
