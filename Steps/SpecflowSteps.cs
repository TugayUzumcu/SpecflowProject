using OpenQA.Selenium;
using SpecflowTemplate.Drivers;
using SpecflowTemplate.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace SpecflowTemplate.Steps
{
    [Binding]
    public sealed class SpecflowSteps : Hooks 
    {
        //static DriverGenerator driverGenerator = new DriverGenerator();
        static IWebDriver driver = driverGenerator.getDriver();

        HomePage homePage = new HomePage(driver);

        [Given(@"the first number is")]
        public void GivenTheFirstNumberIs()
        {
            
        }

    }
}
