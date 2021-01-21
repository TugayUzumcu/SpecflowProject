using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowTemplate.Pages
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public void goToPage()
        {

            //driver.Navigate().GoToUrl("https://webshop.mobiletestautomation.nl/");


        }
    }
}
