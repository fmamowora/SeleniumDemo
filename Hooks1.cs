using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumDemo.Utilities
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {

            driver = new ChromeDriver();
                   
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
