using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;

//the different interactive elements to be used in tests in the search results page

namespace POM_Google_Search_Results_Selectors
{
    public static class Google_Search_Results_Selectors
    {
        public static By FirstResult = By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div[1]/div/div/a");
    }
}
