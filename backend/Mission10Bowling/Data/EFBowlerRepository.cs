﻿using Mission10Bowling.Models;

namespace Mission10Bowling.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _bowlerContext;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;

    }
}
