using OpenQA.Selenium;
using SpecflowTemplate.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowTemplate.Steps
{
    [Binding]
    public class Hooks
    {
        public static DriverGenerator driverGenerator = new DriverGenerator();
        static IWebDriver driver = driverGenerator.getDriver();

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
