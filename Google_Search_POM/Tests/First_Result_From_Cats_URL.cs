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
using System.Threading.Tasks;

namespace POM_First_Result_From_Cats_URL
{
    [TestFixture]
    public class First_Result_From_Cats_URL
    {
        private IWebDriver driver;
        private Google_Search_Results_Page googleSearchResultsPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            googleSearchResultsPage = new Google_Search_Results_Page(driver);
        }

        [Test]
        public void First_Result_From_Cats()
        {
            driver.Navigate().GoToUrl("https://www.google.com/search?q=cats&rlz=1C1ONGR_enUS929US929&oq=cats&gs_lcrp=EgZjaHJvbWUqBwgAEAAYjwIyBwgAEAAYjwIyDQgBEC4YgwEYsQMYgAQyDQgCEAAYgwEYsQMYigUyDQgDEC4YgwEYsQMYgAQyBwgEEAAYgAQyEAgFEAAYgwEYsQMYyQMYgAQyCggGEAAYkgMYgAQyCggHEAAYkgMYigUyDQgIEC4YgwEYsQMYgAQyBwgJEC4YgATSAQ40NzcyNTQ1MzFqMGoxNagCALACAA&sourceid=chrome&ie=UTF-8");
            googleSearchResultsPage.ClickOnFirstResult();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
