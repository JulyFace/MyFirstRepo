using OpenQA.Selenium;


namespace DemoQA.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public IWebElement FirstRow => Driver.FindElement(By.XPath("//li[contains(text(),'Cras justo odio')]"));

        public IWebElement Header => Driver.FindElement(By.XPath("//div[@class='main-header']"));

    }
}



