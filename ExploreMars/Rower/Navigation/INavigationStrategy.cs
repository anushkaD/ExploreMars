namespace ExploreMars
{
    public interface INavigationStrategy
    {
        Rover Execute(Rover currentRower);
    }
}