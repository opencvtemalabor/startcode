﻿using System;
using System.Collections.Generic;
using OpenCvSharp;

namespace Intro.TestImageGenerators
{
    public class BoundingBoxTestImages
    {
        public Mat SimpleRectangleImage(out int minX, out int minY, out int maxX, out int maxY)
        {
            Mat result = new Mat(100, 100, MatType.CV_8UC1, new Scalar(0));
            Scalar color = new Scalar(255);
            Cv2.Rectangle(result, new Rect(10, 10, 81, 81), color);
            minX = 10;
            minY = 10;
            maxX = 90;
            maxY = 90;
            return result;
        }

        public Mat RandomPolygonImage(out int minX, out int minY, out int maxX, out int maxY)
        {
            minX = 100;
            maxX = 0;
            minY = 100;
            maxY = 0;
            Mat result = new Mat(100, 100, MatType.CV_8UC1, new Scalar(0));
            Scalar color = new Scalar(255);
            Random random = new Random(10); // Define seed to make the tests repeatable
            var points = new List<Point>();
            for (int i = 0; i < 6; i++)
            {
                var p = new Point(random.Next(10, 90), random.Next(10, 90));
                points.Add(p);
                if (minX > p.X) minX = p.X;
                if (maxX < p.X) maxX = p.X;
                if (minY > p.Y) minY = p.Y;
                if (maxY < p.Y) maxY = p.Y;
            }
            var pointLists = new List<List<Point>>();
            pointLists.Add(points);
            Cv2.Polylines(result, pointLists, false, color);
            return result;
        }

        public Mat RandomThreeTriangleImage(out int minX, out int minY, out int maxX, out int maxY)
        {
            minX = 100;
            maxX = 0;
            minY = 100;
            maxY = 0;
            Mat result = new Mat(100, 100, MatType.CV_8UC1, new Scalar(0));
            Scalar color = new Scalar(255);
            Random random = new Random(10); // Define seed to make the tests repeatable
            var points = new List<Point>();
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    var p = new Point(random.Next(10, 90), random.Next(10, 90));
                    points.Add(p);
                    if (minX > p.X) minX = p.X;
                    if (maxX < p.X) maxX = p.X;
                    if (minY > p.Y) minY = p.Y;
                    if (maxY < p.Y) maxY = p.Y;
                    var pointLists = new List<List<Point>>();
                    pointLists.Add(points);
                    Cv2.Polylines(result, pointLists, true, color);
                }
            }
            return result;
        }

        public Mat CircleImage(out int minX, out int minY, out int maxX, out int maxY)
        {
            minX = 18;
            maxX = 42;
            minY = 28;
            maxY = 52;
            Mat result = new Mat(100, 100, MatType.CV_8UC1, new Scalar(0));
            Scalar color = new Scalar(255);
            Cv2.Circle(result, new Point(30, 40), 12, color, 1);
            return result;
        }
    }
}