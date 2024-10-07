using Microsoft.AspNetCore.Mvc;
using Padel.Api.Mapping;
using Padel.Application.Models;
using Padel.Application.Repositories;
using Padel.Contracts.Requests;


namespace Padel.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class MatchesController : ControllerBase
    {

        private readonly IMatchRepository _matchRepository;

        public MatchesController(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;

        }
        [HttpPost("matches")]
        public async Task<IActionResult> Create([FromBody]CreateMatchRequest request)
        {
            var match = request.MapToMatch();
            await _matchRepository.CreateAsync(match);
            return Created($"/api/matches/{match.Id}", match);
        }

        [HttpGet("matches")]
        public async Task<IActionResult> GetAll()
        {
            var matches = await _matchRepository.GetAllAsync();
            return Ok(matches);
        }

        [HttpGet("matches/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var match = await _matchRepository.GetByIdAsync(id);
            return Ok(match);
        }

    }
}
