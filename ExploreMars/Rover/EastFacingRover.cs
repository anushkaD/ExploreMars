namespace ExploreMars
{
    public class EastFacingRover : Rover
    {
        public EastFacingRover(int x, int y)
            : base(x, y, "E")
        {
          
        }

        protected override Rover MoveOneGridPoint()
        {
            X += 1;
            return this;
        }

        protected override Rover TurnLeft()
        {
            return new NorthFacingRover(X, Y);
        }

        protected override Rover TurnRight()
        {
            return new SouthFacingRover(X, Y);
        }
    }
}