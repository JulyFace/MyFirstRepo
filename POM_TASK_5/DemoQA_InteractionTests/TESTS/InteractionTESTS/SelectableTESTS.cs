using DemoQA_InteractionTests.Extentions;
using DemoQA_InteractionTests.PAGES.SelectablePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.TESTS.InteractionTESTS
{
    [TestFixture]
    public class SelectableTESTS : BASE_TEST
    {

        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp() 
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            Driver.Manage().Window.Maximize();
            _selectablePage.NavigateTo();

        }

        [TearDown]
        public void TearDown() 
        {
            Driver.Quit();
        
        }

        [Test]
        public void RowColorIsChanged_when_RowIsSelected() 
        {

            var colorBefore = _selectablePage.FirstRow.GetCssColor();

            _selectablePage.FirstRow.Click();

            Assert.AreNotEqual(colorBefore, _selectablePage.FirstRow.GetCssColor());
        
        
        }

        [Test]
        public void RowDontChangeColor_when_RowIsSelectedThenUnselected()
        {

            var colorBefore = _selectablePage.FirstRow.GetCssColor();

            Builder.DoubleClick(_selectablePage.FirstRow).Perform();
            _selectablePage.Header.Click();

            Assert.AreEqual(colorBefore, _selectablePage.FirstRow.GetCssColor());


        }






    }
}
