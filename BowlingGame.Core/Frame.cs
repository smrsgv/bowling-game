namespace BowlingGame.Core
{
    public class Frame
    {
        private int _score;

        public int Score => _score;

        public void Add(int pins)
        {
            _score += pins;
        }
    }
}