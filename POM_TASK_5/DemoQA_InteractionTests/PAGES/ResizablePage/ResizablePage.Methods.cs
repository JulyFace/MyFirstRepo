using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.ResizablePage
{
    public partial class ResizablePage : BASE_PAGE
    {

        public ResizablePage(IWebDriver driver):base(driver)
        {


        }

        public override string CHECH_HOW_THIS_WORK => "http://www.demoqa.com/resizable";

    }
}
