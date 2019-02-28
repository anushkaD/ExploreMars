namespace ExploreMars
{
    public class NorthFacingRover : Rover
    {
        public NorthFacingRover(int x, int y)
            : base(x, y, "N")
        {
        }

        public override Rover MoveOneGridPoint()
        {
            Y += 1;
            return this;
        }

        public override Rover TurnLeft()
        {
            return new WestFacingRover(X, Y);
        }

        public override Rover TurnRight()
        {
            return new EastFacingRover(X, Y);
        }
    }
}