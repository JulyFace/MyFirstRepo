using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace DemoQA.Pages
{
    public abstract class BasePage
    {

        public BasePage(IWebDriver driver)
        {
            Driver = driver;

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

        }

        public virtual string CHECH_HOW_THIS_WORK { get; }

        public IWebDriver Driver { get; }

        //public WebDriverWait Wait { get; }  -->  DONT NEED IT !

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(CHECH_HOW_THIS_WORK);
        }

        //public void WaitForLoad(int timeoutSec = 15)//////////////////////////////////////////////
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        //    WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
        //    wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        //}



    }
}

