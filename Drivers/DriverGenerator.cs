using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecflowTemplate.Drivers
{
    public class DriverGenerator
    {
        private IWebDriver driver;

        public IWebDriver getDriver()
        {
            if(driver == null)
            {
                createDriver();
            }
            return driver;
        }
        private void createDriver()
        {
            driver = new ChromeDriver();
        }
    }
}
