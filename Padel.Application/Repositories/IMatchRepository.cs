using Padel.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padel.Application.Repositories
{
    public interface IMatchRepository
    {

        Task<bool> CreateAsync(Match match);

        Task<Match?> GetByIdAsync(Guid id);

        Task<IEnumerable<Match>> GetAllAsync();

        Task<bool> DeleteByIdAsync(Guid id);

        Task<bool> UpdateAsync(Match match);

    }
}
