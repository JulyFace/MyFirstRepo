
using DemoQA.Pages.SortablePage;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Linq;

namespace DemoQA.TESTS.InteractionTESTS
{
    [TestFixture]
   public class SortableTESTS : BASE_TEST
   {
        SortablePage _sortablePage;

      [SetUp]
      public void SetUp()
      {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            Driver.Manage().Window.Maximize();
            _sortablePage.NavigateTo();


      }


      [TearDown]
      public void TearDown()
      {
         Driver.Quit();

      }

      [Test]
      public void SortBoxex_whenDropBoxOnOtherBox() 
      {
         _sortablePage.SelectGrid.Click();

         
         Builder.ClickAndHold(_sortablePage.PositionONE).MoveToElement(_sortablePage.PositionTHREE).Release().Perform();

         _sortablePage.AssertBoxesLocations("Two", _sortablePage.PositionONE.Text);
         _sortablePage.AssertBoxesLocations("One",_sortablePage.PositionTHREE.Text);

      }


        
        [Test]
        public void ChecksRowsIsOnRightPositionI_when_ChangeTwoRowsPositions()
        {
            var firstRowBefore = _sortablePage.ListOfOptions[0].Text;
            var lastRowBefore = _sortablePage.ListOfOptions[5].Text;


            Builder.ClickAndHold(_sortablePage.ListOfOptions[0])
                    .MoveToElement(_sortablePage.ListOfOptions[5])
                    .Release()
                    .ClickAndHold(_sortablePage.ListOfOptions[0])
                    .MoveToElement(_sortablePage.ListOfOptions[5])
                    .Release()
                    .Perform();


            _sortablePage.AssertBoxesLocations(firstRowBefore, _sortablePage.ListOfOptions[4].Text);
            _sortablePage.AssertBoxesLocations(lastRowBefore, _sortablePage.ListOfOptions[3].Text);

        }





    }
}



