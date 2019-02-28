namespace ExploreMars
{
    public class WestFacingRover : Rover
    {
        public WestFacingRover(int x, int y)
        {
            X = x;
            Y = y;
            Direction = "W";
        }

        public override void MoveOneGridPoint()
        {
            X -= 1;
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