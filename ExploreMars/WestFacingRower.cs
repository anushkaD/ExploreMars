namespace ExploreMars
{
    public class WestFacingRower : Rower
    {
        public WestFacingRower(int x, int y)
        {
            X = x;
            Y = y;
            Direction = "W";
        }

        public override void MoveOneGridPoint()
        {
            X -= 1;
        }

        public override Rower TurnLeft()
        {
            return new SouthFacingRower(X, Y);
        }

        public override Rower TurnRight()
        {
            return new NorthFacingRower(X, Y);
        }
    }
}