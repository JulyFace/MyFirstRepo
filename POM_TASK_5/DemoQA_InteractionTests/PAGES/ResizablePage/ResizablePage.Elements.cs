using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.ResizablePage
{
    public partial class ResizablePage : BASE_PAGE
    {
        public IWebElement ResizableBoxHandle => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']"));


        public IWebElement SecondResizableBox => Driver.FindElement(By.XPath("//div[@id='resizable']//span[@class='react-resizable-handle react-resizable-handle-se']"));


        public IWebElement FirstBoxSize => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']"));


    }
}
