namespace ExploreMars
{
    public class EastFacingRower : Rower
    {
        public EastFacingRower(int x, int y)
        {
            X = x;
            Y = y;
            Direction = "E";
        }

        public override void MoveOneGridPoint()
        {
            X += 1;
        }

        public override Rower TurnLeft()
        {
            return new NorthFacingRower(X, Y);
        }

        public override Rower TurnRight()
        {
            return new SouthFacingRower(X, Y);
        }
    }
}