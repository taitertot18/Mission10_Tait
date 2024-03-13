﻿using Mission10Bowling.Models;

namespace Mission10Bowling.Data
{
    public class EFTeamRepository : ITeamRepository
    {
        private BowlingLeagueContext _teamContext;
        public EFTeamRepository(BowlingLeagueContext temp)
        {
            _teamContext = temp;
        }

        public IEnumerable<Team> Teams => _teamContext.Teams;
    }
}
