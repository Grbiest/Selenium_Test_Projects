using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;

//the different interactive elements to be used in tests in the title page

namespace POM_Google_Title_Selectors
{
    public static class Google_Title_Selectors
    {
        public static By SearchBox = By.Name("q");
        public static By SearchButton = By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]");
        public static By BlankSpace = By.ClassName("lnXdpd");
    }
}
