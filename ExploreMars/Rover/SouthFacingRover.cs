 namespace ExploreMars
{
    public class SouthFacingRover : Rover
    {
        public SouthFacingRover(int x, int y)
            :base(x,y,"S")
        {
        }

        public override Rover MoveOneGridPoint()
        {
            Y -= 1;
            return this;
        }

        public override Rover TurnLeft()
        {
            return new EastFacingRover(X, Y);
        }

        public override Rover TurnRight()
        {
            return new WestFacingRover(X, Y);
        }
    }
}