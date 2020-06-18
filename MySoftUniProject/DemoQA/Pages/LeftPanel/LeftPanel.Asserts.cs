

using NUnit.Framework;

namespace DemoQA.Pages.LeftPanel
{
    public partial class LeftPanel
    {


        public void AssertPageTitle(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, PageTitle.Text);
        }



    }
}
