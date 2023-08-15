using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using POM_Google_Search_Results_Selectors;
using System.Threading.Tasks;

//the different interactions that can be performed on tests on the search results page

namespace POM_Google_Search_Results_Page
{
    public class Google_Search_Results_Page
    {
        private IWebDriver driver;

        public Google_Search_Results_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnFirstResult()
        {
            IWebElement FirstResult = driver.FindElement(Google_Search_Results_Selectors.FirstResult);
            FirstResult.Click();
        }
    }
}
