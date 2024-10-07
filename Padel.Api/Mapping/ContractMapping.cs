using Padel.Application.Models;
using Padel.Contracts.Requests;
using Padel.Contracts.Responses;

namespace Padel.Api.Mapping
{
    public static class ContractMapping
    {

        public static Match MapToMatch(this CreateMatchRequest request)
        {
            var match = new Match
            {
                Id = Guid.NewGuid(),
                CourtId = request.CourtId,
                MatchDateTime = request.MatchDateTime,
                MatchType = request.MatchType,
                CreatedAt = DateTime.UtcNow
               
            };

            return match;
        }

        public static MatchResponse MapToResponse(this Match match)
        {
            return new MatchResponse
            {
                Id = match.Id,
                CourtId = match.CourtId,
                MatchDateTime = match.MatchDateTime,
                MatchType = match.MatchType,
                IsCompleted = match.IsCompleted,
                IsConfirmed = match.IsConfirmed,
                CreatedAt = match.CreatedAt
            };
        }

        public static MatchesResponse MapToResponse (this IEnumerable<Match> matches)
        {
            return new MatchesResponse
            {
                Items = matches.Select(MapToResponse)
            };
        }

        public static Match MapToMatch(this UpdateMatchRequest request, Guid id)
        {
            var match = new Match
            {
                Id = id,
                CourtId = request.CourtId,
                MatchDateTime = request.MatchDateTime,
                MatchType = request.MatchType,
                IsCompleted = request.IsCompleted,
                IsConfirmed = request.IsConfirmed,
           
            };

            return match;
        }
    }
}
