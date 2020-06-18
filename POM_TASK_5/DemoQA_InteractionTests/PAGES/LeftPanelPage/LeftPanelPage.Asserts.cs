using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.PAGES
{
    public partial class LeftPanelPage
    {
       
        
            public void AssertPageTitle(string expectedTitle)
            {
                Assert.AreEqual(expectedTitle, PageTitle.Text);
            }
        


    }
}
