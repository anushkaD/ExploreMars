using System;

namespace ExploreMars
{
    public abstract class Rover
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public string Direction { get; protected set; }
        public string Position { get { return String.Format("{0} {1} {2}", X, Y, Direction); } }

        public abstract void MoveOneGridPoint();
        public abstract Rover TurnRight();
        public abstract Rover TurnLeft();
    }
}