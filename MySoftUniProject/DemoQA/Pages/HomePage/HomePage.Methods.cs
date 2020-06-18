using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.HomePage
{
    public partial class HomePage : BasePage

    {


        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public override string CHECH_HOW_THIS_WORK => "http://demoqa.com";




    }
}
