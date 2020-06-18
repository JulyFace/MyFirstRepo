using OpenQA.Selenium;


namespace DemoQA.Pages.HomePage
{
    public partial class HomePage : BasePage
    {



        public IWebElement HomePageSectionsButton(string sectionName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']/ancestor::div[contains(@class, 'top-card')]"));




    }
}
