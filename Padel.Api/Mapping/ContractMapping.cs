using Padel.Application.Models;
using Padel.Contracts.Requests;

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
                MatchType = request.MatchType
            };

            return match;
        }
    }
}
