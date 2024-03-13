using Mission10Bowling.Models;

namespace Mission10Bowling.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get;}
    }
}
