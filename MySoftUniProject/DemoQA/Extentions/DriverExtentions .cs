using OpenQA.Selenium;

namespace DemoQA.Extentions
{
    public static class DriverExtentions
    {

        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);


        }


    }
}
