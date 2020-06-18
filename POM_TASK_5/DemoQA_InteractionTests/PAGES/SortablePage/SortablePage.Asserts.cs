using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.SortablePage
{
    public partial class SortablePage : BASE_PAGE
    {

        public void AssertBoxesLocations(string expected ,string actual) 
        {
            Assert.AreEqual(expected, actual);

        }

        public void AssertRowsLocations(double expected, double actual)
        {
            Assert.AreEqual(expected, actual);

        }
    }
}
