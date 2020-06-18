using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.SortablePage
{
    public partial class SortablePage : BASE_PAGE
    {
        public SortablePage(IWebDriver driver):base(driver)
        {
           

        }

        public override string CHECH_HOW_THIS_WORK => "http://www.demoqa.com/sortable";
    }
}
