﻿using System;
using Intro;
using Intro.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCvSharp;

namespace Tests
{
    [TestClass]
    public class TestIntro
    {
        [TestMethod]
        public void TestIntroBasics()
        {
            IntroHelper helper = new IntroHelper();
            Mat image = helper.CreateEmptyGreenImage();
        }
    }
}
