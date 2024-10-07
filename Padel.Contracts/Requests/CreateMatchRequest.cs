using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padel.Contracts.Requests
{
    public class CreateMatchRequest
    {
        public required Guid CourtId { get; init; }
        public required DateTime MatchDateTime { get; init; }

        public required string MatchType { get; init; }
    }


}
