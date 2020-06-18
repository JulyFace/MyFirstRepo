using DemoQA.Extentions;
using DemoQA.Pages.HomePage;
using DemoQA.Pages.LeftPanel;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.TESTS
{
    public class NavigationTests : BASE_TEST
    {

        private HomePage _homePage;
        private LeftPanel _leftPanelPage;


        [SetUp]
        public void SetUp()
        {

            Initialize();
            _homePage = new HomePage(Driver);
            _leftPanelPage = new LeftPanel(Driver);
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
