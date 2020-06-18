using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.SortablePage
{
    public partial class SortablePage : BASE_PAGE
    {
        //GRID

        public IWebElement SelectGrid => Driver.FindElement(By.XPath("//*[@id='demo-tab-grid']"));

        public IWebElement PositionONE => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(1)"));

        public IWebElement PositionTWO => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)"));


        public IWebElement PositionTHREE => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)"));




        // LIST

        public IWebElement RowONE => Driver.FindElement(By.CssSelector("#demo-tabpane-list>div>div:nth-child(1)"));


        public IWebElement RowTWO => Driver.FindElement(By.CssSelector("#demo-tabpane-list>div>div:nth-child(2)"));
        

        public IWebElement RowTHREE => Driver.FindElement(By.CssSelector("#demo-tabpane-list>div>div:nth-child(3)"));
        

        public IWebElement RowFOUR => Driver.FindElement(By.CssSelector("#demo-tabpane-list>div>div:nth-child(4)"));
        

        public IWebElement RowFIVE => Driver.FindElement(By.CssSelector("#demo-tabpane-list>div>div:nth-child(5)"));
        

        public IWebElement RowSIX => Driver.FindElement(By.CssSelector("#demo-tabpane-list>div>div:nth-child(6)"));





        public IWebElement RowOneAfter => Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='One']"));
       
        public IWebElement RowTwoAfter => Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Two']"));
       

        public IWebElement RowThreeAfter => Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Three']"));
        

        public IWebElement RowFourAfter => Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Four']"));
        

        public IWebElement RowFiveAfter => Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Five']"));
        

        public IWebElement RowSixAfter => Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Six']"));
        




    }
}
