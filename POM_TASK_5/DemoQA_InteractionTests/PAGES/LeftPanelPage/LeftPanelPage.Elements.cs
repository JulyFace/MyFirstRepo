using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES
{
    public partial class LeftPanelPage
    {


        protected IWebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public IWebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));

        public IWebElement SubMenu(string subName) => Driver.FindElement(By.XPath($"//span[contains(text(),'{subName}')]"));             // LeftPanel.Fin...       $".//*[normalize-space(text())='{subName}']"));

        public IWebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));




    }
}
