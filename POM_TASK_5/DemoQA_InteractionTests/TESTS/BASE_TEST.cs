using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace DemoQA_InteractionTests.TESTS
{
    [TestFixture]



    public class BASE_TEST
    {


        protected IWebDriver Driver { get; set; }

        protected Actions Builder { get; set; }

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Builder = new Actions(Driver);
        }
    }


}
