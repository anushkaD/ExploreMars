namespace ExploreMars
{
    public class MoveOneGridPointStrategy : INavigationStrategy
    {
        public Rover Execute(Rover rover)
        {
            return rover.MoveOneGridPoint();
        }
    }
}