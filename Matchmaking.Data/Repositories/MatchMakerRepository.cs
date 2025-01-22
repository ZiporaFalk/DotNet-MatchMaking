using Matchmaking.Core;
using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Data.Repositories
{
    public class MatchMakerRepository : IMatchMakerRepository
    {
        private readonly DataContext _context;

        public MatchMakerRepository(DataContext context)
        {
            _context = context;
        }
        public List<MatchMaker> GetList()
        {
            return _context.matchmakers.ToList();
        }
        public MatchMaker GetById(int id)
        {
            return _context.matchmakers.FirstOrDefault(x => x.Id == id);
        }
        public MatchMaker GetByName(string name)
        {
            return _context.matchmakers.FirstOrDefault(x => x.Name == name);
        }
        public void Add(MatchMaker matchMaker)
        {
            _context.matchmakers.Add(matchMaker);
        }
        public void UpdatePrice(int id, int price)
        {
            MatchMaker m = _context.matchmakers.FirstOrDefault(x => x.Id == id);
            m.Price = price;
        }
        public void Delete(int id)
        {
            MatchMaker m = _context.matchmakers.FirstOrDefault(x => x.Id == id);
            _context.matchmakers.Remove(m);
        }



    }

}
