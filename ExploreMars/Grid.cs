using System;

namespace ExploreMars
{

    public class Grid
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rower ActiveRower
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
                    return ActiveRower.Position;

                case InstructionType.GridSize:
                    SetGridSize(instructions);
                    return string.Empty;

                case InstructionType.RowerLanding:
                    SetActiveRower(instructions);
                    return ActiveRower.Position;

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
            ActiveRower = RowerFactory.Create(instructions.Direction,
                                instructions.X,
                                instructions.Y);
        }

        private void MoveActiveRower(char[] instructions)
        {
            for (int i = 0; i < instructions.Length; i++)
            {
                Navigate(instructions[i]);

            }
        }

        private void Navigate(char instruction)
        {
            switch ((NavigationInstructions)instruction)
            {
                case NavigationInstructions.TurnLeft:
                    ActiveRower = ActiveRower.TurnLeft();
                    break;
                case NavigationInstructions.TurnRight:
                    ActiveRower = ActiveRower.TurnRight();
                    break;
                case NavigationInstructions.MoveOneGridPoint:
                    ActiveRower.MoveOneGridPoint();
                    break;
            }
        }

    }
}