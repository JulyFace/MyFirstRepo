using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.SelectablePage
{
    public partial class SelectablePage : BASE_PAGE
    {
        public IWebElement FirstRow => Driver.FindElement(By.XPath("//li[contains(text(),'Cras justo odio')]"));

        public IWebElement Header => Driver.FindElement(By.XPath("//div[@class='main-header']"));

    }
}



