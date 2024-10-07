using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padel.Contracts.Requests
{
    public class UpdateMatchRequest
    {
      
        public required Guid CourtId { get; init; }

        public required DateTime MatchDateTime { get; init; }

        public required string MatchType { get; init; }


        public required bool IsCompleted { get; init; }

        public required bool IsConfirmed { get; init; }



    }
}
