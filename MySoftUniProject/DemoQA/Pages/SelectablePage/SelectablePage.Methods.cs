﻿using DemoQA.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver): base(driver)
        {
                
        }

        public override string CHECH_HOW_THIS_WORK => "http://www.demoqa.com/selectable";
    }
}
