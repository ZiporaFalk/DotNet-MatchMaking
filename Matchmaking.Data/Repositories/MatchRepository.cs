using Matchmaking.Core;
using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Data.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly DataContext _context;

        public MatchRepository(DataContext context)
        {
            _context = context;
        }

        public List<Match> GetList()
        {
            return _context.matches.ToList();
        }
        public Match GetById(int id)
        {
            return _context.matches.FirstOrDefault(x => x.Id == id);
        }
        public Match GetByDate(DateTime date)
        {
            return _context.matches.FirstOrDefault(x => x.Date == date);
        }
        public void Add(Match match)
        {
            _context.matches.Add(match);
        }

        public void Delete(int id)
        {
            Match m = _context.matches.FirstOrDefault(x => x.Id == id);
            _context.matches.Remove(m);
        }

    }
}
