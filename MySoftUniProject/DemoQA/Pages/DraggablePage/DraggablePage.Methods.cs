using OpenQA.Selenium;

namespace DemoQA.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {

        }


        public override string CHECH_HOW_THIS_WORK => "http://www.demoqa.com/dragabble";

    }
}
