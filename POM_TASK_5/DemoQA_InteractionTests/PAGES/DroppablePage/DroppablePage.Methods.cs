using DemoQA_InteractionTests.TESTS;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.DroppablePage
{
    public partial class DroppablePage : BASE_PAGE
    {

        public DroppablePage(IWebDriver driver)
         : base(driver)
        {

        }

       public override string CHECH_HOW_THIS_WORK => "http://demoqa.com/droppable";


    }
}
