using Matchmaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Repositories
{
    public interface IMatchMakerRepository
    {
        List<MatchMaker> GetList();

        MatchMaker GetById(int id);

        MatchMaker GetByName(string name);

        void Add(MatchMaker matchMaker);

        void UpdatePrice(int id, int price);

        void Delete(int id);




    }
}
