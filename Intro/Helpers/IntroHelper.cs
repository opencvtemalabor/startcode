using System;
using OpenCvSharp;

namespace Intro.Helpers
{
    public class IntroHelper
    {
        public Mat CreateEmptyGreenImage()
        {
            return new Mat(480, 640, MatType.CV_8UC3, new Scalar(0,255,0));
        }

        public Vec3b GetPixelColor(Mat image, Point p)
        {
            if (image.Type() != MatType.CV_8UC3)
                throw new ArgumentException("Only CV_8UC3 images are supported...");
            var indexer = image.GetGenericIndexer<Vec3b>();
            Vec3b color = indexer[p.Y, p.X];
            return color;
        }
    }
}
