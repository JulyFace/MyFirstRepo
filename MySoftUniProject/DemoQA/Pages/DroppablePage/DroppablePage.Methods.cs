using DemoQA.Pages;
using OpenQA.Selenium;


namespace DemoQA_InteractionTests.PAGES.DroppablePage
{
    public partial class DroppablePage : BasePage
    {

        public DroppablePage(IWebDriver driver)
         : base(driver)
        {

        }

       public override string CHECH_HOW_THIS_WORK => "http://demoqa.com/droppable";


    }
}
