using System;

namespace ExploreMars
{
    public static class RoverFactory
    {
        public static Rover Create(char direction, int x, int y)
        {
            switch (direction)
            {
                case 'S':
                    return new SouthFacingRover(x, y);
                case 'E':
                    return new EastFacingRover(x, y);
                case 'W':
                    return new WestFacingRover(x, y);
                case 'N':
                    return new NorthFacingRover(x, y);
                default:
                    throw new ArgumentException();
            }
        }
    }
}