 namespace ExploreMars
{
    public class SouthFacingRover : Rover
    {
        public SouthFacingRover(int x, int y)
        {
            X = x;
            Y = y;
            Direction = "S";
        }

        public override void MoveOneGridPoint()
        {
            Y -= 1;
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