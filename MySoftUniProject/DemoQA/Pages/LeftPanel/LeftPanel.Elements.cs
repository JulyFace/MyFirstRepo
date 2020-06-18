using OpenQA.Selenium;


namespace DemoQA.Pages.LeftPanel
{
    public partial class LeftPanel
    {


        protected IWebElement LeftPanelSection => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public IWebElement InteractionsButton => LeftPanelSection.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));

        public IWebElement SubMenu(string subName) => Driver.FindElement(By.XPath($"//span[contains(text(),'{subName}')]"));             // LeftPanel.Fin...       $".//*[normalize-space(text())='{subName}']"));

        public IWebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));




    }
}
