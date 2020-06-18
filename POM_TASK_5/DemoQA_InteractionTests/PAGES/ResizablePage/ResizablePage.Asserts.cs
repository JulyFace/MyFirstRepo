using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.ResizablePage
{
    public partial class ResizablePage : BASE_PAGE
    {
        public void AssertLocation(double expected, double actual)  
        {
            Assert.AreNotEqual(expected,  actual);


        }
    }
}
