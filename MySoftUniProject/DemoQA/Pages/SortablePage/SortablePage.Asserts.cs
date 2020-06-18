using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQA.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    { 

        public void AssertBoxesLocations(string expected ,string actual) 
        {
            Assert.AreEqual(expected, actual);

        }

        public void AssertRowsLocations(double expected, double actual)
        {
            Assert.AreEqual(expected, actual);

        }

        //public void AssertBoxesPosition(int expected, int actual)
        //{
        //    for (int i = 0; i<= ListOfOptions.Count;i++)
        //    {
        //        Assert.AreEqual(, ListOfOptions[ListOfOptions.Count - i ]);
        //    }
        
        //}
    }
}
