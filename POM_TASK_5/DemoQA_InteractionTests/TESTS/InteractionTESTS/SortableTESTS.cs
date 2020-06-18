using DemoQA_InteractionTests.PAGES.SortablePage;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_InteractionTests.TESTS.InteractionTESTS
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
        public void ChecksIfEveryRowIsOnRightPositionI_when_ChangeTwoRowsPositions()
        {
            

            Builder.ClickAndHold(_sortablePage.RowONE)
                    .MoveToElement(_sortablePage.RowSIX)
                    .Release()
                    .ClickAndHold(_sortablePage.RowONE)
                    .MoveToElement(_sortablePage.RowSIX)
                    .Release()
                    .Perform();

            


            Assert.AreEqual(_sortablePage.RowONE.Location, _sortablePage.RowThreeAfter.Location);
            
            Assert.AreEqual(_sortablePage.RowTWO.Location, _sortablePage.RowFourAfter.Location);

            Assert.AreEqual(_sortablePage.RowTHREE.Location, _sortablePage.RowFiveAfter.Location);
                          
            Assert.AreEqual(_sortablePage.RowFOUR.Location, _sortablePage.RowSixAfter.Location);
                          
            Assert.AreEqual(_sortablePage.RowFIVE.Location, _sortablePage.RowOneAfter.Location);
                          
            Assert.AreEqual(_sortablePage.RowSIX.Location, _sortablePage.RowTwoAfter.Location);
                          

        }


    }
}



