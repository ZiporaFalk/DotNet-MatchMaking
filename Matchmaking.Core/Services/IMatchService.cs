using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Services
{
    public interface IMatchService
    {
        List<Match> GetAll();

        Match GetById(int id);

        Match GetByDate(DateTime date);

        void Add(Match match);

        void Delete(int id);

    }
}
