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
    public class MatchMakerService : IMatchMakerService
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IMatchMakerRepository _matchMakerRepository;
        public MatchMakerService(IMatchMakerRepository matchMakerRepository, IManagerRepository managerRepository)
        {
            _matchMakerRepository = matchMakerRepository;
            _managerRepository = managerRepository;
        }

        public List<MatchMaker> GetAll()
        {
            return _matchMakerRepository.GetList();
        }

        public MatchMaker GetById(int id)
        {
            return _matchMakerRepository.GetById(id);
        }
        public MatchMaker GetByName(string name)
        {
            return _matchMakerRepository.GetByName(name);
        }
        public void Add(MatchMaker matchMaker)
        {
            _matchMakerRepository.Add(matchMaker);
            _managerRepository.save();

        }
        public void UpdatePrice(int id, int price)
        {
            _matchMakerRepository.UpdatePrice(id, price);
            _managerRepository.save();

        }
        public void Delete(int id)
        {
            _matchMakerRepository.Delete(id);
            _managerRepository.save();
        }


    }
}
