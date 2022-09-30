
using Intro.Helpers;

namespace Tests
{
    public class TestIntro
    {
        [Fact]
        public void TestIntroBasics()
        {
            IntroHelper helper = new IntroHelper();
            Mat image = helper.CreateEmptyGreenImage();
        }
    }
}
