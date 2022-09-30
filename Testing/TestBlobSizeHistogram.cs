using Intro.Solutions;
using Intro.TestImageGenerators;

namespace Tests
{
    /// <summary>
    /// Summary description for TestBlobSizeHistogram
    /// </summary>
    public class TestBlobSizeHistogram
    {
        public TestBlobSizeHistogram()
        {
        }

        [Fact]
        public void BlobSizeHistogramEmptyImage()
        {
            var gen = new BlobSizeHistogramTestImages();
            Mat image = gen.EmptyImage();
            var hist = new BlobSizeHistogramTask();
            var blobCount = hist.GetBlobNumberInAreaRange(image, 0, 100);
            Assert.Equal(0, blobCount);
        }

        [Fact]
        public void BlobSizeHistogramRandomBlobs()
        {
            var gen = new BlobSizeHistogramTestImages();
            int correctNumber;
            int minArea = 100;
            int maxArea = 350;
            Mat image = gen.RandomBlobs(minArea, maxArea, out correctNumber);
            var hist = new BlobSizeHistogramTask();
            var blobCount = hist.GetBlobNumberInAreaRange(image, minArea, maxArea);
            Assert.Equal(correctNumber, blobCount);
        }
    }
}
