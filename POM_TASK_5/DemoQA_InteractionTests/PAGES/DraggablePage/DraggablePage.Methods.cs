using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.DraggablePage
{
    public partial class DraggablePage : BASE_PAGE
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {

        }


        public override string CHECH_HOW_THIS_WORK => "http://www.demoqa.com/dragabble";

    }
}
