using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using Pract31.PageObjects;

namespace Pract31
{
    internal class TestClass
    {

        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test] 
        public void TestGoogleSearch()
        {
            HomePage naslovna = new HomePage(driver);
            naslovna.GoToPage();
            naslovna.SearchFor("C# Selenium PageObject Model");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
            
    }
}
