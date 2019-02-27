using System;

namespace ExploreMars
{
    public static class RowerFactory
    {
        public static Rower Create(char direction, int x, int y)
        {
            switch (direction)
            {
                case 'S':
                    return new SouthFacingRower(x, y);
                case 'E':
                    return new EastFacingRower(x, y);
                case 'W':
                    return new WestFacingRower(x, y);
                case 'N':
                    return new NorthFacingRower(x, y);
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}