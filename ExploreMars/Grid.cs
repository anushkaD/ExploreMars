using System;

namespace ExploreMars
{

    public class Grid
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        private Rover ActiveRover
        {
            get;
            set;
        }

        public Grid(int width,int height)
        {
            Width = width;
            Height = height;
        }

        public string LandRover(char direction,int x,int y)
        {
            ActiveRover = RoverFactory.Create(direction,  x, y);
            return ActiveRover.Position;
        }

        public string Explore(char[] instructions)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                ActiveRover = ActiveRover.Navigate(instructions[i]);
            }

            return ActiveRover.Position;
        }

    }
}