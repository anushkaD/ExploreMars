namespace ExploreMars
{
    public class SouthFacingRower : Rower
    {
        public SouthFacingRower(int x, int y)
        {
            X = x;
            Y = y;
            Direction = "S";
        }

        public override void MoveOneGridPoint()
        {
            Y -= 1;
        }

        public override Rower TurnLeft()
        {
            return new EastFacingRower(X, Y);
        }

        public override Rower TurnRight()
        {
            return new WestFacingRower(X, Y);
        }
    }
}