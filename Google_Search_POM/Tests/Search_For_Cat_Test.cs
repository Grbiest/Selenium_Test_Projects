using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using POM_Google_Search_Results_Page;
using POM_Google_Search_Results_Selectors;
using POM_Google_Title_Pages;
using POM_Google_Title_Selectors;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace POM_Search_For_Cats_Test
{
    [TestFixture]
    public class Search_For_Cats_Test
    {
        private IWebDriver driver;
        private Google_Title_Page googleTitlePage;
        private Google_Search_Results_Page googleSearchResultsPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            googleTitlePage= new Google_Title_Page(driver);
            googleSearchResultsPage = new Google_Search_Results_Page(driver);
        }

        [Test]
        public void Search_For_Cats()
        {

            driver.Navigate().GoToUrl("https://www.google.com/");
            googleTitlePage.TypeInSearchBox("cats");
            googleTitlePage.DeSelect();
            googleTitlePage.ClickSearch();
            googleSearchResultsPage.ClickOnFirstResult();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
