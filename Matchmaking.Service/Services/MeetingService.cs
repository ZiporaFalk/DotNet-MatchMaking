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
    public class MeetingService : IMeetingService
    {
        private readonly IManagerRepository _managerRepository;

        private readonly IMeetingRepository _meetingRepository;
        public MeetingService(IMeetingRepository meetingRepository, IManagerRepository managerRepository)
        {
            _meetingRepository = meetingRepository;
            _managerRepository = managerRepository;
        }
        public List<Meeting> GetAll()
        {
            return _meetingRepository.GetList();
        }
        public Meeting GetById(int id)
        {
            return _meetingRepository.GetById(id);
        }
        //public Meeting GetByIdResume(int id)
        //{
        //    return _meetingRepository.GetByIdResume(id);
        //}
        public void Add(Meeting meeting)
        {
            _meetingRepository.Add(meeting);
            _managerRepository.save();

        }
        public void UpdatePlace(int id, string place)
        {
            _meetingRepository.UpdatePlaace(id, place);
            _managerRepository.save();

        }
        public void Delete(int id)
        {
            _meetingRepository.Delete(id);
            _managerRepository.save();

        }


    }
}
