using DemoQA.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public IWebElement ResizableBoxHandle => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']"));


        public IWebElement SecondResizableBox => Driver.FindElement(By.XPath("//div[@id='resizable']//span[@class='react-resizable-handle react-resizable-handle-se']"));


        public IWebElement FirstBoxSize => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']"));


    }
}
