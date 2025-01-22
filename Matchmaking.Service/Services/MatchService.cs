using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using Matchmaking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Service.Services
{
    public class MatchService : IMatchService
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IMatchRepository _matchRepository;
        public MatchService(IMatchRepository matchRepository, IManagerRepository managerRepository)
        {
            _matchRepository = matchRepository;
            _managerRepository = managerRepository;
        }

        public List<Match> GetAll()
        {
            return _matchRepository.GetList();
        }

        public Match GetById(int id)
        {
            return _matchRepository.GetById(id);
        }
        public Match GetByDate(DateTime date)
        {
            return _matchRepository.GetByDate(date);
        }

        public void Add(Match match)
        {
            _matchRepository.Add(match);
            _managerRepository.save();

        }

        public void Delete(int id)
        {
            _matchRepository.Delete(id);
            _managerRepository.save();
        }

    }
}
