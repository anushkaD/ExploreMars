namespace ExploreMars
{
    public class WestFacingRover : Rover
    {
        public WestFacingRover(int x, int y)
            : base(x, y, "W")
        {
        }

        public override Rover MoveOneGridPoint()
        {
            X -= 1;
            return this;
        }

        public override Rover TurnLeft()
        {
            return new SouthFacingRover(X, Y);
        }

        public override Rover TurnRight()
        {
            return new NorthFacingRover(X, Y);
        }
    }
}