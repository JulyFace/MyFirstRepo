using OpenQA.Selenium;

namespace DemoQA.Extentions
{
    public static class ElementExtentions
    {
        public static string GetCssColor(this IWebElement element)
        {
            return element.GetCssValue("background-color");
        }

    }
}
