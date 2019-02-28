namespace ExploreMars
{
    public class EastFacingRover : Rover
    {
        public EastFacingRover(int x, int y)
            : base(x, y, "E")
        {
          
        }

        public override Rover MoveOneGridPoint()
        {
            X += 1;
            return this;
        }

        public override Rover TurnLeft()
        {
            return new NorthFacingRover(X, Y);
        }

        public override Rover TurnRight()
        {
            return new SouthFacingRover(X, Y);
        }
    }
}