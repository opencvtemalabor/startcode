using Intro.Solutions;
using Intro.TestImageGenerators;

namespace Tests
{
    /// <summary>
    /// Summary description for TestBoundingBox
    /// </summary>
    public class TestBoundingBox
    {
        [Fact]
        public void BoundingBoxSimpleRectangleImage()
        {
            // Note: if the left side of a rectangle is in column 10 and its width is 10,
            //  then the right side will be in column 19 (and not 20)!
            BoundingBoxTestImages genBBox = new BoundingBoxTestImages();
            int minX, minY, maxX, maxY;
            Mat image = genBBox.SimpleRectangleImage(out minX, out minY, out maxX, out maxY);
            BoundingBoxTask bboxTask = new BoundingBoxTask();
            Rect bbox = bboxTask.GetBoundingBox(image);
            Assert.Equal(minX, bbox.X);
            Assert.Equal(minY, bbox.Y);
            Assert.Equal(maxX, bbox.X + bbox.Width - 1);
            Assert.Equal(maxY, bbox.Y + bbox.Height - 1);
        }

        [Fact]
        public void BoundingBoxRandomPolygonImage()
        {
            BoundingBoxTestImages genBBox = new BoundingBoxTestImages();
            int minX, minY, maxX, maxY;
            Mat image = genBBox.RandomPolygonImage(out minX, out minY, out maxX, out maxY);
            BoundingBoxTask bboxTask = new BoundingBoxTask();
            Rect bbox = bboxTask.GetBoundingBox(image);
            Assert.Equal(minX, bbox.X);
            Assert.Equal(minY, bbox.Y);
            Assert.Equal(maxX, bbox.X + bbox.Width - 1);
            Assert.Equal(maxY, bbox.Y + bbox.Height - 1);
        }

        [Fact]
        public void BoundingBoxThreeTriangleImage()
        {
            BoundingBoxTestImages genBBox = new BoundingBoxTestImages();
            int minX, minY, maxX, maxY;
            Mat image = genBBox.RandomThreeTriangleImage(out minX, out minY, out maxX, out maxY);
            BoundingBoxTask bboxTask = new BoundingBoxTask();
            Rect bbox = bboxTask.GetBoundingBox(image);
            Assert.Equal(bbox.X, minX);
            Assert.Equal(bbox.Y, minY);
            Assert.Equal(bbox.X + bbox.Width - 1, maxX);
            Assert.Equal(bbox.Y + bbox.Height - 1, maxY);
        }

        [Fact]
        public void BoundingBoxCircleImage()
        {
            BoundingBoxTestImages genBBox = new BoundingBoxTestImages();
            int minX, minY, maxX, maxY;
            Mat image = genBBox.CircleImage(out minX, out minY, out maxX, out maxY);
            BoundingBoxTask bboxTask = new BoundingBoxTask();
            Rect bbox = bboxTask.GetBoundingBox(image);
            Assert.Equal(bbox.X, minX);
            Assert.Equal(bbox.Y, minY);
            Assert.Equal(bbox.X + bbox.Width - 1, maxX);
            Assert.Equal(bbox.Y + bbox.Height - 1, maxY);
        }
    }
}
