using Intro.Solutions;
using Intro.TestImageGenerators;

namespace Tests
{
    /// <summary>
    /// Summary description for TestConnectedComponents
    /// </summary>
    public class TestConnectedComponents
    {
        [Fact]
        public void ConnectedComponentsTrivialImage()
        {
            var cc = new ConnectedComponentsTask();
            var gen = new ConnectedComponentsTestImages();
            int correctAnswer;
            Mat image = gen.TrivialImage(out correctAnswer);
            int answer = cc.CountConnectedComponents(image);
            Assert.Equal(correctAnswer, answer);
        }

        [Fact]
        public void ConnectedComponentsSingleRectImage()
        {
            var cc = new ConnectedComponentsTask();
            var gen = new ConnectedComponentsTestImages();
            int correctAnswer;
            Mat image = gen.SingleRectImage(out correctAnswer);
            int answer = cc.CountConnectedComponents(image);
            Assert.Equal(correctAnswer, answer);
        }

        [Fact]
        public void ConnectedComponentsComplexShapeImage()
        {
            var cc = new ConnectedComponentsTask();
            var gen = new ConnectedComponentsTestImages();
            int correctAnswer;
            Mat image = gen.ComplexShapeImage(out correctAnswer);
            int answer = cc.CountConnectedComponents(image);
            Assert.Equal(correctAnswer, answer);
        }

        [Fact]
        public void ConnectedComponentsThinLineShapeImage()
        {
            var cc = new ConnectedComponentsTask();
            var gen = new ConnectedComponentsTestImages();
            int correctAnswer;
            Mat image = gen.ThinLineShapeImage(out correctAnswer);
            int answer = cc.CountConnectedComponents(image);
            Assert.Equal(correctAnswer, answer);
        }

        [Fact]
        public void ConnectedComponentsCirclesInGridSkipDiagonalImage()
        {
            var cc = new ConnectedComponentsTask();
            var gen = new ConnectedComponentsTestImages();
            int correctAnswer;
            Mat image = gen.CirclesInGridSkipDiagonalImage(out correctAnswer);
            int answer = cc.CountConnectedComponents(image);
            Assert.Equal(correctAnswer, answer);
        }

        [Fact]
        public void ConnectedComponentsImageWithText()
        {
            var cc = new ConnectedComponentsTask();
            var gen = new ConnectedComponentsTestImages();
            int correctAnswer;
            Mat image = gen.ImageWithText(out correctAnswer);
            int answer = cc.CountConnectedComponents(image);
            Assert.Equal(correctAnswer, answer);
        }

        [Fact]
        public void ConnectedComponentsThinLinksAndGapsImage()
        {
            var cc = new ConnectedComponentsTask();
            var gen = new ConnectedComponentsTestImages();
            Mat image = gen.ThinLinksAndGapsImage();

            int originalAnswer = cc.CountConnectedComponents(image);
            Assert.Equal(4, originalAnswer);

            Mat dilated3 = cc.Dilate(image, 3);
            int dilated3Answer = cc.CountConnectedComponents(dilated3);
            Assert.Equal(3, dilated3Answer);

            Mat dilated8 = cc.Dilate(image, 8);
            int dilated8Answer = cc.CountConnectedComponents(dilated8);
            Assert.Equal(2, dilated8Answer);

            Mat eroded1 = cc.Erode(image, 1);
            int eroded1Answer = cc.CountConnectedComponents(eroded1);
            Assert.Equal(5, eroded1Answer);
        }
    }
}
