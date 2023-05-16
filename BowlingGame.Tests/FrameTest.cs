using BowlingGame.Core;
using Xunit;

namespace BowlingGame.Tests
{
    public class FrameTest
    {
        [Fact]
        public void TestScoreNoThrows()
        {
            var frame = new Frame();

            Assert.Equal(0, frame.Score);
        }
    }
}
