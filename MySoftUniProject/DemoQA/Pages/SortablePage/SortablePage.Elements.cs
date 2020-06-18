
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace DemoQA.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        //GRID

        public IWebElement SelectGrid => Driver.FindElement(By.XPath("//*[@id='demo-tab-grid']"));

        public IWebElement PositionONE => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(1)"));

        public IWebElement PositionTWO => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)"));


        public IWebElement PositionTHREE => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)"));






        public List<IWebElement> ListOfOptions => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();



    }
}
