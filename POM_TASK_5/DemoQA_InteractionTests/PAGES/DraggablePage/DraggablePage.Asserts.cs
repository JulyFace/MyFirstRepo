using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES.DraggablePage
{
    public partial class DraggablePage
    {
        
        public void AssertLocations(double maxValue , double actualValue,double delta ) 
        {
            Assert.AreEqual(maxValue, actualValue, delta);
        
        
        
        
        }



    }
}
