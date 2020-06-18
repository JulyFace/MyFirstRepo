using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.SelectablePage
{
    public partial class SelectablePage : BASE_PAGE
    {
        public SelectablePage(IWebDriver driver): base(driver)
        {
                
        }

        public override string CHECH_HOW_THIS_WORK => "http://www.demoqa.com/selectable";
    }
}
