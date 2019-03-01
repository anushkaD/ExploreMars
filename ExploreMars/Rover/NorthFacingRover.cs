namespace ExploreMars
{
    public class NorthFacingRover : Rover
    {
        public NorthFacingRover(int x, int y)
            : base(x, y, "N")
        {
        }

        protected override Rover MoveOneGridPoint()
        {
            Y += 1;
            return this;
        }

        protected override Rover TurnLeft()
        {
            return new WestFacingRover(X, Y);
        }

        protected override Rover TurnRight()
        {
            return new EastFacingRover(X, Y);
        }
    }
}