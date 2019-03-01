 namespace ExploreMars
{
    public class SouthFacingRover : Rover
    {
        public SouthFacingRover(int x, int y)
            :base(x,y,"S")
        {
        }

        protected override Rover MoveOneGridPoint()
        {
            Y -= 1;
            return this;
        }

        protected override Rover TurnLeft()
        {
            return new EastFacingRover(X, Y);
        }

        protected override Rover TurnRight()
        {
            return new WestFacingRover(X, Y);
        }
    }
}