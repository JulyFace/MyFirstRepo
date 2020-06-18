using DemoQA.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        
        public void AssertLocations(double maxValue , double actualValue,double delta ) 
        {
            Assert.AreEqual(maxValue, actualValue, delta);
        
        
        
        
        }



    }
}
