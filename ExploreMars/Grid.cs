using System;

namespace ExploreMars
{

    public class Grid
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rover ActiveRover
        {
            get;
            private set;
        }

        public string Input(string input)
        {
            try
            {
                var instructions = new Instructions(input);
                return ExecuteInstructions(instructions);
            }
            catch
            {
                throw new InvalidOperationException("Invalid Input");
            }


        }

        private string ExecuteInstructions(Instructions instructions)
        {
            switch (instructions.Type)
            {
                case InstructionType.Move:
                    MoveActiveRower(instructions.NavigationInstrunctions);
                    return ActiveRover.Position;

                case InstructionType.GridSize:
                    SetGridSize(instructions);
                    return string.Empty;

                case InstructionType.RowerLanding:
                    SetActiveRower(instructions);
                    return ActiveRover.Position;

                default:
                    return string.Empty;
            }
        }

        private void SetGridSize(Instructions instructions)
        {
            Width = instructions.Width;
            Height = instructions.Height;
        }

        private void SetActiveRower(Instructions instructions)
        {
            ActiveRover = RoverFactory.Create(instructions.Direction,
                                instructions.X,
                                instructions.Y);
        }

        private void MoveActiveRower(char[] instructions)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                ActiveRover = ActiveRover.Navigate(instructions[i]);
            }
        }

    }
}