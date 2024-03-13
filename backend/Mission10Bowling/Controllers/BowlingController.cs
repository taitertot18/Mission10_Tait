using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10Bowling.Data;
using Mission10Bowling.Models;

namespace Mission10Bowling.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlingController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepository.Bowlers.ToArray();

            return bowlerData;
        }

    }
}
