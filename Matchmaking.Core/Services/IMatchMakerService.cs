using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Services
{
    public interface IMatchMakerService
    {

        List<MatchMaker> GetAll();

        MatchMaker GetById(int id);

        MatchMaker GetByName(string name);

        void Add(MatchMaker matchMaker);

        void UpdatePrice(int id, int price);

        void Delete(int id);


    }
}
