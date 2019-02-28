using System;

namespace ExploreMars
{
    public class NavigationStrategyFactory
    {
        public NavigationStrategyFactory(char instruction)
        {
            Instruction = instruction;
        }

        public char Instruction { get; }

        public INavigationStrategy Create()
        {
            switch ((NavigationInstructions)Instruction)
            {
                case NavigationInstructions.TurnLeft:
                    return new TurnLeftStrategy();
                case NavigationInstructions.TurnRight:
                    return new TurnRightStrategy();
                case NavigationInstructions.MoveOneGridPoint:
                    return new MoveOneGridPointStrategy();
            }
            throw new InvalidOperationException();
        }
    }
}