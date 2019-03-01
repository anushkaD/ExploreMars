namespace ExploreMars
{
    public class WestFacingRover : Rover
    {
        public WestFacingRover(int x, int y)
            : base(x, y, "W")
        {
        }

        protected override Rover MoveOneGridPoint()
        {
            X -= 1;
            return this;
        }

        protected override Rover TurnLeft()
        {
            return new SouthFacingRover(X, Y);
        }

        protected override Rover TurnRight()
        {
            return new NorthFacingRover(X, Y);
        }
    }
}