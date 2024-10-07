using Padel.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padel.Application.Repositories
{
    public class MatchRepository : IMatchRepository
    {

        private readonly List<Match> _matches = new List<Match>();

        public Task<bool> CreateAsync(Match match)
        {
           _matches.Add(match);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteByIdAsync(Guid id)
        {
           var removeCount = _matches.RemoveAll(x => x.Id == id);
            var movieRemoved = removeCount > 0;
            return Task.FromResult(movieRemoved);
        }

        public Task<IEnumerable<Match>> GetAllAsync()
        {
            return Task.FromResult(_matches.AsEnumerable());
        }

        public Task<Match?> GetByIdAsync(Guid id)
        {
            var match = _matches.SingleOrDefault(x => x.Id == id);

            return Task.FromResult(match);

        }

        public Task<bool> UpdateAsync(Match match)
        {
            var matchIndex = _matches.FindIndex(x => x.Id == match.Id);
            if(matchIndex == -1) {
                return Task.FromResult(false);
            }

            _matches[matchIndex] = match;

            return Task.FromResult(true);
            

        }
    }
}
