using DemoQA.Pages;
using OpenQA.Selenium;

namespace DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {

        public ResizablePage(IWebDriver driver):base(driver)
        {


        }

        public override string CHECH_HOW_THIS_WORK => "http://www.demoqa.com/resizable";

    }
}
