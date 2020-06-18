using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.DraggablePage
{
    public partial class DraggablePage : BASE_PAGE
    {
        public IWebElement DraggBox => Driver.FindElement(By.Id("dragBox"));


        public IWebElement AxisRestricted => Driver.FindElement(By.XPath("//*[@id='draggableExample-tab-axisRestriction']"));


        public IWebElement OnlyX_Box => Driver.FindElement(By.XPath("//*[@id='restrictedX']"));



        public IWebElement ContainerRestrictedButton => Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-containerRestriction']"));

        public IWebElement TextInBox => Driver.FindElement(By.XPath("//span[@class='ui-widget-header ui-draggable ui-draggable-handle']"));





    }
}
