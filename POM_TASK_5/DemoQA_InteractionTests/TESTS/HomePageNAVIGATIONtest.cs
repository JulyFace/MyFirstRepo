using DemoQA_InteractionTests.PAGES;
using DemoQA_InteractionTests.PAGES.DroppablePage;
using DemoQA_InteractionTests.PAGES.HomePage;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA_InteractionTests.TESTS
{
    public class HomePageNAVIGATIONtest : BASE_TEST
    {

        private HomePage _homePage;
        private LeftPanelPage _leftPanelPage;


        [SetUp]
        public void SetUp()
        {

            Initialize();
            _homePage = new HomePage(Driver);
            _leftPanelPage = new LeftPanelPage(Driver);
            _homePage.NavigateTo();
            _homePage.HomePageSectionsButton("Interactions").Click();

        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void PageLoaded_when_NavigateToInteractionsDropDowns(string subName)
        {

            var dropDownNavigation = Driver.FindElement(By.XPath($"//*[normalize-space(text())='{subName}']"));

            Driver.ScrollTo(dropDownNavigation);
            _leftPanelPage.SubMenu(subName).Click();


            _leftPanelPage.AssertPageTitle(subName);


        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }



    }
}
