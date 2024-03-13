using Mission10Bowling.Models;

namespace Mission10Bowling.Data
{
    public interface ITeamRepository
    {
        IEnumerable<Team> Teams { get; }
    }

}
