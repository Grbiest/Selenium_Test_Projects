using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using POM_Google_Title_Selectors;
using System.Threading.Tasks;


//the different interactions that can be performed on tests on the title page

namespace POM_Google_Title_Pages
{
    public class Google_Title_Page
    {
        private IWebDriver driver;

        public Google_Title_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeInSearchBox(string searchText)
        {
            IWebElement SearchBox = driver.FindElement(Google_Title_Selectors.SearchBox);
            SearchBox.SendKeys(searchText);
        }

        public void DeSelect()
        {
            IWebElement BlankSpace = driver.FindElement(Google_Title_Selectors.BlankSpace);
            BlankSpace.Click();
        }

        public void ClickSearch()
        {
            IWebElement SearchButton = driver.FindElement(Google_Title_Selectors.SearchButton);
            SearchButton.Click();
        }

    }
}
