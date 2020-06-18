using DemoQA.Pages.DraggablePage;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.TESTS.InteractionTESTS
{
    [TestFixture]
    public class DraggableTESTS : BASE_TEST
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _draggablePage = new DraggablePage(Driver);

            _draggablePage.NavigateTo();


        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }

        [Test]
        public void PossitionIsChanged_when_BoxIsMoved_SIMPLE()
        {
            var boxPositionBefore = _draggablePage.DraggBox.Location;

            Builder.DragAndDropToOffset(_draggablePage.DraggBox, 100, 100).Perform();

            Assert.AreNotEqual(boxPositionBefore, _draggablePage.DraggBox.Location);

        }

        [Test]
        public void Y_RestrictedMovement_when_DownMoveIsSet_AXISrestricted()
        {
            _draggablePage.AxisRestricted.Click();

            var YpositionBefore = _draggablePage.OnlyX_Box.Location.Y;

            Builder.DragAndDropToOffset(_draggablePage.OnlyX_Box, 100, 100).Perform();

            Assert.AreEqual(YpositionBefore, _draggablePage.OnlyX_Box.Location.Y);


        }


        [Test]
        public void TextRestrictedByContainer_when_MovemenToPointOutsideTheContainerIsSet() 
        {
            _draggablePage.ContainerRestrictedButton.Click();

            
            Builder.DragAndDropToOffset(_draggablePage.TextInBox, 100, 100).Perform();

            var x_locationAfter = _draggablePage.TextInBox.Location.X;
            var y_locationAfter = _draggablePage.TextInBox.Location.Y;

            _draggablePage.AssertLocations(314d, x_locationAfter, 3);
            _draggablePage.AssertLocations(663d, y_locationAfter, 3);


        }

    }
}
