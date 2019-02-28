namespace ExploreMars
{
    public class TurnRightStrategy : INavigationStrategy
    {
        public Rover Execute(Rover rover)
        {
            return rover.TurnRight();
        }
    }
}