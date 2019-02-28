using System;

namespace ExploreMars
{  

    public class Instructions
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }
        private char Direction { get; set; }
        private char[] NavigationInstrunctions { get; set; }
        private InstructionType Type { get; set; }
        public Grid ExploreArea { get; private set; }

        public string Process(string input)
        {
            try
            {
                ConvertToInstructions(input);
                return ExecuteInstructions();
            }
            catch
            {
                throw new InvalidOperationException("Invalid Input");
            }

        }

        private void ConvertToInstructions(string input)
        {
            var instructions = input.Split(' ');
            SetInstructionProperties(instructions);
        }

        private void SetInstructionProperties(string[] instructions)
        {
            if (IsMovingInstructions(instructions))
            {
                Type = InstructionType.Move;
                NavigationInstrunctions = instructions[0].ToCharArray();

            }
            else if (IsSize(instructions))
            {
                Type = InstructionType.GridSize;
                Width = int.Parse(instructions[0]);
                Height = int.Parse(instructions[1]);
            }
            else if (IsRowerLanding(instructions))
            {
                Type = InstructionType.RowerLanding;
                X = int.Parse(instructions[0]);
                Y = int.Parse(instructions[1]);
                Direction = char.Parse(instructions[2]);
            }
        }

        private bool IsMovingInstructions(string[] instructions)
        {
            return instructions.Length == 1;
        }

        private bool IsRowerLanding(string[] instructions)
        {
            return instructions.Length == 3;
        }

        private bool IsSize(string[] instructions)
        {
            return instructions.Length == 2;
        }

        private string ExecuteInstructions()
        {
            switch (Type)
            {
                case InstructionType.GridSize:
                    ExploreArea = new Grid(Width, Height);
                    return string.Empty;                         

                case InstructionType.RowerLanding:
                    return ExploreArea.LandRover(Direction, X, Y);

                case InstructionType.Move:
                    return ExploreArea.MoveActiveRower(NavigationInstrunctions);
            }

            throw new InvalidOperationException();
        }
    }

    enum InstructionType
    {
        Move,
        GridSize,
        RowerLanding,
    }
}