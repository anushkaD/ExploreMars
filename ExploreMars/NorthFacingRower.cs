namespace ExploreMars
{
    public class NorthFacingRower : Rower
    {
        public NorthFacingRower(int x, int y)
        {
            X = x;
            Y = y;
            Direction = "N";
        }

        public override void MoveOneGridPoint()
        {
           Y += 1;
        }

        public override Rower TurnLeft()
        {
            return new WestFacingRower(X,Y); 
        }

        public override Rower TurnRight()
        {
            return new EastFacingRower(X, Y);
        }
    }
}