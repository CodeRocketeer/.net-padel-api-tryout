using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padel.Application.Models
{
    public class Match
    {
        public required Guid Id { get; init; }
        public  required Guid CourtId { get; init; }

        public required DateTime MatchDateTime { get; init; }

        public required string MatchType { get; init; }

        public  bool IsCompleted { get; init; }

        public bool IsConfirmed { get; init; }
    } 
}
