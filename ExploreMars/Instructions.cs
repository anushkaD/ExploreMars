namespace ExploreMars
{
    public class Instructions
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public char Direction { get; private set; }
        public char[] NavigationInstrunctions { get; private set; }
        public InstructionType Type { get; private set; }

        public Instructions(string input)
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
    }
}