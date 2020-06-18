using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public void AssertLocation(double expected, double actual)  
        {
            Assert.AreNotEqual(expected,  actual);


        }
    }
}
