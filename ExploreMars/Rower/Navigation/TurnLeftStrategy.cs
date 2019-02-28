namespace ExploreMars
{
    public class TurnLeftStrategy : INavigationStrategy
    {
        public Rover Execute(Rover rover)
        {
            return rover.TurnLeft();
        }
    }
}