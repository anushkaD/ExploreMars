using System;

namespace ExploreMars
{
    enum NavigationInstructions
    {
        TurnRight = 'R',
        TurnLeft = 'L',
        MoveOneGridPoint = 'M'
    }

    public abstract class Rover
    {
        public Rover(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public string Direction { get; private set; }
        public string Position { get { return string.Format("{0} {1} {2}", X, Y, Direction); } }

        protected abstract Rover MoveOneGridPoint();
        protected abstract Rover TurnRight();
        protected abstract Rover TurnLeft();

        public Rover Navigate(char instruction)
        {
            return ExecuteNavigationInstruction(instruction);
        }

        private Rover ExecuteNavigationInstruction(char instruction)
        {
            switch ((NavigationInstructions)instruction)
            {
                case NavigationInstructions.TurnLeft:
                    return TurnLeft();
                case NavigationInstructions.TurnRight:
                    return TurnRight();
                case NavigationInstructions.MoveOneGridPoint:
                    return MoveOneGridPoint();
            }
            throw new ArgumentException();
        }
    }
}