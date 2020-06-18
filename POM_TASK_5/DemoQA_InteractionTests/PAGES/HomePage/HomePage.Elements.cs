using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.HomePage
{
    public partial class HomePage : BASE_PAGE
    {

      
        
            public IWebElement HomePageSectionsButton(string sectionName) =>
                Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']/ancestor::div[contains(@class, 'top-card')]"));

        
        

    }
}
