using System;

namespace ExploreMars
{
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
        public string Position { get { return String.Format("{0} {1} {2}", X, Y, Direction); } }

        public abstract Rover MoveOneGridPoint();
        public abstract Rover TurnRight();
        public abstract Rover TurnLeft();

        public Rover Navigate(char instruction)
        {
            var navigationStrategy = new NavigationStrategyFactory(instruction).Create();
            return navigationStrategy.Execute(this);
        }
    }
}