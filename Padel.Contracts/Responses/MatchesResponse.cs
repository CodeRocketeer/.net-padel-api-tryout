using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padel.Contracts.Responses
{
    public class MatchesResponse
    {
        public IEnumerable<MatchResponse> Items { get; init; }  = [];
    }
}
