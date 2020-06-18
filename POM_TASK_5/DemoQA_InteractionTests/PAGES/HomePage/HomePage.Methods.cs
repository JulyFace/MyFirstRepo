using OpenQA.Selenium;

namespace DemoQA_InteractionTests.PAGES.HomePage
{
    public partial class HomePage 
    {


        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public override string CHECH_HOW_THIS_WORK => "http://demoqa.com";




    }
}
