using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.Extentions
{
    public static class GetCSScolor
    {

        public static string GetCssColor(this IWebElement element)
        {
            return element.GetCssValue("background-color");
        }

    }
}
