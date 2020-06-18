
using DemoQA.Extentions;
using DemoQA.Pages.ResizablePage;
using NUnit.Framework;


namespace DemoQA.TESTS.InteractionTESTS
{
    [TestFixture]
    public class ResizableTESTS : BASE_TEST
    {


        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            
            _resizablePage = new ResizablePage(Driver);
            Driver.Manage().Window.Maximize();

            _resizablePage.NavigateTo();
             

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();


        }


        [Test]
        public void ChangeBoxSize_when_DragResizebleHandle()
        {
            double y_locationBefore =  _resizablePage.ResizableBoxHandle.Location.X;
            double x_locationBefore = _resizablePage.ResizableBoxHandle.Location.X;


            Builder.DragAndDropToOffset(_resizablePage.ResizableBoxHandle, 200, 100).Perform();


            _resizablePage.AssertLocation(x_locationBefore, _resizablePage.ResizableBoxHandle.Location.X );
            _resizablePage.AssertLocation(y_locationBefore, _resizablePage.ResizableBoxHandle.Location.Y );


        }


        [Test]
        public void ChangeSECONDBoxSize_when_DragResizebleHandle()
        {
            double y_locationBefore = _resizablePage.SecondResizableBox.Location.X;
            double x_locationBefore = _resizablePage.SecondResizableBox.Location.X;

           

            Driver.ScrollTo(_resizablePage.SecondResizableBox);


            Builder.DragAndDropToOffset(_resizablePage.SecondResizableBox, 10, 10).Perform();


            _resizablePage.AssertLocation(x_locationBefore, _resizablePage.SecondResizableBox.Location.X);
            _resizablePage.AssertLocation(y_locationBefore, _resizablePage.SecondResizableBox.Location.Y);


        }


        [Test]
        public void ChecksBoxSize_when_DragResizebleHandleToSizeMin()
        {
            Driver.ScrollTo(_resizablePage.ResizableBoxHandle);
            
          
            Builder.DragAndDropToOffset(_resizablePage.ResizableBoxHandle, -50,-50) .Perform();

            
            Assert.AreEqual("width: 150px; height: 150px;", _resizablePage.FirstBoxSize.GetAttribute("style"));


        }
        


    }
}
