using Microsoft.AspNetCore.Mvc;
using Padel.Api.Mapping;
using Padel.Application.Models;
using Padel.Application.Repositories;
using Padel.Contracts.Requests;


namespace Padel.Api.Controllers
{
    [ApiController]
    public class MatchesController : ControllerBase
    {

        private readonly IMatchRepository _matchRepository;

        public MatchesController(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;

        }
        [HttpPost(ApiEndpoints.Matches.Create)]
        public async Task<IActionResult> Create([FromBody]CreateMatchRequest request)
        {
            var match = request.MapToMatch();
            await _matchRepository.CreateAsync(match);
            return CreatedAtAction(nameof(Get), new { id = match.Id }, match);
            
        }

        [HttpGet(ApiEndpoints.Matches.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var matches = await _matchRepository.GetAllAsync();
            var matchesResponse = matches.MapToResponse();
            return Ok(matchesResponse);
        }

        [HttpGet(ApiEndpoints.Matches.Get)]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
           var match = await _matchRepository.GetByIdAsync(id);
            if (match == null) { return NotFound(); }
            var response = match.MapToResponse();
            return Ok(response);
        }

        [HttpDelete(ApiEndpoints.Matches.Delete)]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _matchRepository.DeleteByIdAsync(id);
            if (!deleted) { return NotFound(); }
            return Ok(deleted);
        }

        [HttpPut(ApiEndpoints.Matches.Update)]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateMatchRequest request)
        {
            var match = request.MapToMatch(id);
            var updated = await _matchRepository.UpdateAsync(match);
            if(!updated) { return NotFound(); }
            var response = match.MapToResponse();
            return Ok(response);
        }

    }
}
