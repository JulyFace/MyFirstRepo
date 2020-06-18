using OpenQA.Selenium;
using System;

namespace DemoQA_InteractionTests
{
    
    

        public static class DriverExtension
        {
            public static void ScrollTo(this IWebDriver driver, IWebElement element)
            {

                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);


            }

        }



                     //   MY HOMEWORK WITHOUT POM 

                    
        ////////////////////////////////////////////////////////////////

       

        //namespace Task2_InteractionTests
        //    {

        //        [TestFixture]

        //        public class Interactions
        //        {
        //            private IWebDriver _driver;
        //            private WebDriverWait _wait;
        //            private Actions _builder;

        //            [SetUp]
        //            public void SetUp()
        //            {
        //                _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        //                _driver.Manage().Window.Maximize();

        //                _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        //                _builder = new Actions(_driver);

        //            }

        //            [Test]
        //            [TestCase("Sortable")]
        //            [TestCase("Selectable")]
        //            [TestCase("Resizable")]
        //            [TestCase("Droppable")]
        //            [TestCase("Dragabble")]
        //            public void T0_1_NavigationButtonsCheck(string sectionName)
        //            {
        //                _driver.Url = "http://www.demoqa.com";

        //                var interactions = _driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[contains(@class, 'top-card')]"));
        //                interactions.Click();

        //                // var interactButton = _driver.FindElement(By.XPath("//h5[normalize-space(text())='Interactions']/ancestor::*[@class='card mt-4 top-card']"));               //("//div[contains(@class,'element-list collapse show')]"));
        //                // interactButton.Click();    ---->   WORKS TOO

        //                var dropDawnNavigation = _driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']"));
        //                _driver.ScrollTo(dropDawnNavigation);
        //                dropDawnNavigation.Click();

        //                var pageHeader = _driver.FindElement(By.ClassName("main-header"));

        //                Assert.AreEqual(sectionName, pageHeader.Text);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T0_Navigate_To_Draggable()
        //            {
        //                _driver.Url = "http://www.demoqa.com";

        //                var interactButton = _driver.FindElement(By.XPath("//h5[normalize-space(text())='Interactions']/ancestor::*[@class='card mt-4 top-card']"));               //("//div[contains(@class,'element-list collapse show')]"));
        //                interactButton.Click();

        //                var interactionOptions = _driver.FindElements(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[@class='element-group']//li"));                                           // ($"//*[normalize-space(text())='{sectionName}']"));
        //                _driver.ScrollTo(interactionOptions[3]);
        //                interactionOptions[3].Click();

        //                _driver.Quit();

        //            }


        //            [Test]

        //            public void T1DragAndDropBox_whenNewLocationIsSet_Draggable()

        //            {
        //                _driver.Url = "http://www.demoqa.com/dragabble";

        //                var draggBox = _wait.Until<IWebElement>(d => d.FindElement(By.Id("dragBox")));
        //                var placeToDrop = _driver.FindElement(By.Id("botton-text-10"));
        //                var dragBoxPositionBefore = draggBox.Location;


        //                _builder
        //                   .DragAndDrop(draggBox, placeToDrop)
        //                   .Perform();

        //                var draggBoxPositionAfter = draggBox.Location;

        //                Assert.AreNotEqual(dragBoxPositionBefore, draggBoxPositionAfter);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T2PositionsChecks_whenDragTheBox_Draggable()

        //            {
        //                _driver.Url = "http://www.demoqa.com/dragabble";

        //                var dragBox = _wait.Until<IWebElement>(d => d.FindElement(By.Id("dragBox")));
        //                dragBox.Click();

        //                var dragBoxFirstPosition = dragBox.Location;


        //                _builder
        //                    .ClickAndHold(dragBox)
        //                    .MoveByOffset(-120, -150)
        //                    .Perform();

        //                var dragBoxPositionAfterMove = dragBox.Location;

        //                Assert.AreNotEqual(dragBoxFirstPosition, dragBoxPositionAfterMove);

        //                _driver.Quit();

        //            }
        //            [Test]
        //            public void T3_Y_RestrictedMovement_whenDownMoveIsSet_Draggable()

        //            {
        //                _driver.Url = "http://www.demoqa.com/dragabble";

        //                IWebElement axisRestricted = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='draggableExample-tab-axisRestriction']")));
        //                axisRestricted.Click();

        //                IWebElement onlyXBox = _driver.FindElement(By.XPath("//*[@id='restrictedX']"));
        //                onlyXBox.Click();

        //                var Yposition = onlyXBox.Location.Y;


        //                var Xmoves = 100;
        //                var Ymoves = 100;

        //                _builder

        //                    .DragAndDropToOffset(onlyXBox, Xmoves, Ymoves)
        //                    .Perform();

        //                var YpositionAfterMove = onlyXBox.Location.Y;

        //                Assert.AreEqual(Yposition, YpositionAfterMove);

        //                _driver.Quit();


        //            }

        //            [Test]
        //            public void T4_X_RestrictedMovement_whenLeftMoveIsSet_Draggable()
        //            {
        //                _driver.Url = "http://www.demoqa.com/dragabble";

        //                IWebElement axisRestricted = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='draggableExample-tab-axisRestriction']")));
        //                axisRestricted.Click();

        //                IWebElement onlyYBox = _driver.FindElement(By.XPath("//*[@id='restrictedY']"));
        //                onlyYBox.Click();

        //                int Xlocation = onlyYBox.Location.X;

        //                var Xmoves = 100;
        //                var Ymoves = 100;

        //                _builder

        //                    .DragAndDropToOffset(onlyYBox, Xmoves, Ymoves)
        //                    .Perform();
        //                var XpositionAfterMove = onlyYBox.Location.X;

        //                Assert.AreEqual(Xlocation, XpositionAfterMove);

        //                _driver.Quit();

        //            }
        //            [Test]
        //            public void T5_Droppable_SimpleTest_BoxColorAndPosition_Check()
        //            {

        //                _driver.Url = "http://www.demoqa.com/droppable";

        //                IWebElement dragMeBox = _wait.Until<IWebElement>(d => d.FindElement(By.Id("draggable")));

        //                var dropMeBox = _wait.Until<IWebElement>(d => d.FindElement(By.Id("droppable")));

        //                var targetBoxColorBoforeMove = dropMeBox.GetCssValue("background-color");
        //                var sourceBoxLocationBeforeMove = dragMeBox.Location;

        //                _builder
        //                    .ClickAndHold(dragMeBox)
        //                    .MoveToElement(dropMeBox)
        //                    .Release(dragMeBox)
        //                    .Perform();

        //                var sourceBoxPositionAfterMove = dragMeBox.Location;
        //                var targetBoxColorAfterMove = dropMeBox.GetCssValue("background-color");

        //                Assert.IsTrue(sourceBoxLocationBeforeMove != sourceBoxPositionAfterMove);

        //                Assert.AreNotEqual(targetBoxColorBoforeMove, targetBoxColorAfterMove);

        //                _driver.Quit();


        //            }

        //            [Test]
        //            public void T6_Droppable_DontAcceptDraggableBox_whenMovedToTargetBox()
        //            {

        //                _driver.Url = "http://www.demoqa.com/droppable";

        //                IWebElement AcceptDroppable = _wait.Until<IWebElement>
        //                    (d => d.FindElement(By.XPath("//*[@id='droppableExample-tab-accept']")));
        //                AcceptDroppable.Click();

        //                var sourceWillNotAcceptBox = _wait.Until<IWebElement>
        //                    (d => d.FindElement(By.XPath("//*[@id='notAcceptable']")));
        //                sourceWillNotAcceptBox.Click();

        //                var targetBox = _wait.Until<IWebElement>
        //                    (d => d.FindElement(By.XPath("//div[@id='acceptDropContainer']//div[@id='droppable']")));

        //                var targetBoxColorBoforeMove = targetBox.GetCssValue("background-color");
        //                var sourceBoxLocationBeforeMove = sourceWillNotAcceptBox.Location;

        //                _builder
        //                .ClickAndHold(sourceWillNotAcceptBox)
        //                .MoveToElement(targetBox)
        //                .Release(sourceWillNotAcceptBox)
        //                .Perform();

        //                var sourceBoxPositionAfterMove = sourceWillNotAcceptBox.Location;
        //                var targetBoxColorAfterMove = targetBox.GetCssValue("background-color");

        //                Assert.IsTrue(sourceBoxLocationBeforeMove != sourceBoxPositionAfterMove);

        //                Assert.AreEqual(targetBoxColorBoforeMove, targetBoxColorAfterMove);

        //                _driver.Quit();


        //            }

        //            [Test]
        //            public void T7_Droppable_RevertBox_whenMovedToTargetBox()
        //            {

        //                _driver.Url = "http://www.demoqa.com/droppable";

        //                IWebElement revertDroppable = _wait.Until<IWebElement>
        //                    (d => d.FindElement(By.XPath("//*[@id='droppableExample-tab-revertable']")));
        //                revertDroppable.Click();

        //                var sourceWilRevertBox = _wait.Until<IWebElement>
        //                    (d => d.FindElement(By.XPath("//*[@id='revertable']")));
        //                sourceWilRevertBox.Click();

        //                var targetBox = _wait.Until<IWebElement>
        //                    (d => d.FindElement(By.XPath("//div[@id='revertableDropContainer']//div[@id='droppable']")));

        //                var targetBoxColorBoforeMove = targetBox.GetCssValue("background-color");
        //                var sourceBoxLocationBeforeMove = sourceWilRevertBox.Location;

        //                _builder
        //                .ClickAndHold(sourceWilRevertBox)
        //                .MoveToElement(targetBox)
        //                .Release(sourceWilRevertBox)
        //                .Perform();

        //                var sourceBoxPositionAfterMove = sourceWilRevertBox.Location;
        //                var targetBoxColorAfterMove = targetBox.GetCssValue("background-color");

        //                Assert.AreNotEqual(targetBoxColorBoforeMove, targetBoxColorAfterMove);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T8_Resizable_ChangeBoxSize_whenDragResizebleHandle()

        //            {
        //                _driver.Url = "http://www.demoqa.com/resizable";

        //                var dragBox = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span")));
        //                dragBox.Click();

        //                var dragBoxFirstPosition = dragBox.Location;

        //                _builder
        //                    .ClickAndHold(dragBox)
        //                    .MoveByOffset(100, 50)
        //                    .Perform();

        //                var dragBoxPositionAfterMove = dragBox.Location;

        //                Assert.IsTrue(dragBoxFirstPosition != dragBoxPositionAfterMove);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T9_Resizable_ChangeBoxSize_whenDragResizebleHandle()
        //            {
        //                _driver.Url = "http://www.demoqa.com/resizable";

        //                var resizableBox = _wait.Until<IWebElement>(d => d.FindElement
        //                    (By.XPath("//*[@id='resizableBoxWithRestriction']/span")));
        //                resizableBox.Click();

        //                IWebElement positionBefore = _driver.FindElement
        //                    (By.XPath("//*[@class='react-resizable-handle react-resizable-handle-se']"));

        //                var positionBeforeContains = positionBefore.GetAttribute("style");

        //                _builder
        //                    .ClickAndHold(resizableBox)
        //                    .MoveByOffset(50, 50)
        //                    .Release(resizableBox)
        //                    .Perform();

        //                IWebElement positionAFTER = _driver.FindElement
        //                    (By.XPath("//*[@class='react-resizable-handle react-resizable-handle-se']"));

        //                var positionAfterContain = positionAFTER.GetAttribute("style");

        //                Assert.AreEqual(positionBeforeContains, positionAfterContain);

        //                _driver.Quit();

        //            }
        //            [Test]
        //            public void T_10_Selectable_EveryElementChangesColor_whenSelected()
        //            {
        //                _driver.Url = "http://www.demoqa.com/selectable";

        //                var selectGrid = _wait.Until<IWebElement>(d => d.FindElement(By.Id("demo-tab-grid")));
        //                selectGrid.Click();


        //                var BoxOne = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='row1']/li[1]")));
        //                var colorBeforeBoxOne = BoxOne.GetCssValue("background-color");

        //                var BoxFive = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='row2']/li[2]")));
        //                var colorBeforeBoxFive = BoxOne.GetAttribute("background-color");

        //                var BoxNine = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='row3']/li[3]")));
        //                var colorBeforeBoxNine = BoxNine.GetCssValue("background-color");


        //                BoxOne.Click();

        //                BoxFive.Click();

        //                BoxNine.Click();

        //                var colorAfterBoxOne = BoxOne.GetCssValue("background-color");

        //                var colorAfterBoxFive = BoxOne.GetCssValue("background-color");

        //                var colorAfterBoxNine = BoxNine.GetCssValue("background-color");

        //                Assert.AreNotSame(colorBeforeBoxOne, colorAfterBoxOne);
        //                Assert.AreNotSame(colorBeforeBoxFive, colorAfterBoxFive);
        //                Assert.AreNotSame(colorBeforeBoxNine, colorAfterBoxNine);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T_11_Selectable_SelectAndUnselectElement_whenClickOnIt()
        //            {
        //                _driver.Url = "http://www.demoqa.com/selectable";

        //                var elementCrasJustoOdio = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='verticalListContainer']/li[1]")));

        //                var elementDapibusAcFacilisisIn = _wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='verticalListContainer']/li[2]")));
        //                var colorElementBefore = elementCrasJustoOdio.GetCssValue("background-color");

        //                _builder
        //                    .DoubleClick(elementCrasJustoOdio)
        //                    .MoveToElement(elementDapibusAcFacilisisIn)
        //                    .Perform();

        //                var colorElementAfter = elementCrasJustoOdio.GetCssValue("background-color");

        //                Assert.AreEqual(colorElementBefore, colorElementAfter);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T_12_Sortable_SortBoxex_whenDropBoxOnOtherBox()
        //            {
        //                _driver.Url = "http://www.demoqa.com/sortable";

        //                var selectGrid = _wait.Until<IWebElement>
        //                    (d => d.FindElement(By.XPath("//*[@id='demo-tab-grid']")));
        //                selectGrid.Click();

        //                IWebElement positionONE = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(1)")));
        //                var BoxOneTextBefore = positionONE.Text;

        //                IWebElement positionTWO = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)")));
        //                var BoxTwoTextBefore = positionTWO.Text;

        //                _builder
        //                    .ClickAndHold(positionONE)
        //                    .MoveToElement(positionTWO)
        //                    .Release()
        //                    .Perform();

        //                IWebElement positionONEAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(1)")));
        //                var BoxOneTextAfter = positionONEAfter.Text;

        //                IWebElement positionThreeAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)")));
        //                var BoxThreeTextAfter = positionThreeAfter.Text;

        //                Assert.AreEqual("Two", BoxOneTextAfter);
        //                Assert.AreEqual("One", BoxThreeTextAfter);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T_13_Sortable_SortElements_whenChangePositionOfElement()
        //            {
        //                _driver.Url = "http://www.demoqa.com/sortable";

        //                IWebElement positionONE = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(1)")));
        //                var positionOneTextBefore = positionONE.Text;

        //                IWebElement positionSix = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(6)")));
        //                var positionSixTextBefore = positionSix.Text;

        //                _builder
        //                    .ClickAndHold(positionONE)
        //                    .MoveToElement(positionSix)
        //                    .Release()
        //                    .ClickAndHold(positionONE)
        //                    .MoveToElement(positionSix)
        //                    .Release()
        //                    .Perform();

        //                IWebElement positionONEAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(1)")));
        //                var positionOneTextAfter = positionONEAfter.Text;

        //                IWebElement positionSixAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(6)")));
        //                var PositionSixTextAfter = positionSixAfter.Text;

        //                Assert.AreEqual("Three", positionOneTextAfter);
        //                Assert.AreEqual("Two", PositionSixTextAfter);

        //                _driver.Quit();

        //            }

        //            [Test]
        //            public void T_14_Sortable_ChecksEveryBoxPosition_whenChangeTwoBoxPositions()
        //            {
        //                _driver.Url = "http://www.demoqa.com/sortable";

        //                IWebElement positionBoxOneBefore = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(1)")));
        //                var positionONE = positionBoxOneBefore.Location;

        //                IWebElement positionBoxTwoBefore = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(2)")));
        //                var positionTWO = positionBoxTwoBefore.Location;

        //                IWebElement positionBoxThreeBefore = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(3)")));
        //                var positionThree = positionBoxThreeBefore.Location;

        //                IWebElement positionBoxFourBefore = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(4)")));
        //                var positionFour = positionBoxFourBefore.Location;

        //                IWebElement positionBoxFiveBefore = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(5)")));
        //                var positionFIVE = positionBoxFiveBefore.Location;

        //                IWebElement positionBoxSixBefore = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.CssSelector("#demo-tabpane-list>div>div:nth-child(6)")));
        //                var positionSIX = positionBoxSixBefore.Location;

        //                _builder
        //                    .ClickAndHold(positionBoxOneBefore)
        //                    .MoveToElement(positionBoxSixBefore)
        //                    .Release()
        //                    .ClickAndHold(positionBoxOneBefore)
        //                    .MoveToElement(positionBoxSixBefore)
        //                    .Release()
        //                    .Perform();

        //                IWebElement boxONEAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='One']")));
        //                var positionBoxOneAfter = boxONEAfter.Location;

        //                IWebElement boxTwoAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Two']")));
        //                var positionBoxTwoAfter = boxTwoAfter.Location;

        //                IWebElement boxThreeAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Three']")));
        //                var positionBoxThreeAfter = boxThreeAfter.Location;

        //                IWebElement boxFourAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Four']")));
        //                var positionBoxFourAfter = boxFourAfter.Location;

        //                IWebElement boxFiveAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Five']")));
        //                var positionBoxFiveAfter = boxFiveAfter.Location;

        //                IWebElement boxSixAfter = _wait.Until<IWebElement>
        //                    (d => d.FindElement
        //                    (By.XPath("//div[@class='vertical-list-container mt-4']//*[normalize-space(text())='Six']")));
        //                var positionBoxSixAfter = boxSixAfter.Location;


        //                Assert.AreEqual(positionBoxOneAfter, positionFIVE);
        //                Assert.AreEqual(positionBoxTwoAfter, positionSIX);
        //                Assert.AreEqual(positionBoxThreeAfter, positionONE);
        //                Assert.AreEqual(positionBoxFourAfter, positionTWO);
        //                Assert.AreEqual(positionBoxFiveAfter, positionThree);
        //                Assert.AreEqual(positionBoxSixAfter, positionFour);

        //                _driver.Quit();

        //            }






        //        }

    

















}

