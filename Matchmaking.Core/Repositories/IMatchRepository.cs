using Matchmaking.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Repositories
{
    public interface IMatchRepository
    {
        List<Match> GetList();

        Match GetById(int id);

        Match GetByDate(DateTime date);

        void Add(Match match);

        void Delete(int id);


    }
}
