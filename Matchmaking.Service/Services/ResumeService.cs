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
    public class ResumeService : IResumeService
    {
        private readonly IManagerRepository _managerRepository;

        private readonly IResumeRepository _resumeRepository;
        public ResumeService(IResumeRepository resumeRepository, IManagerRepository managerRepository)
        {
            _resumeRepository = resumeRepository;
            _managerRepository = managerRepository;
        }
        public List<Resume> GetAll()
        {
            return _resumeRepository.GetList();
        }
        public Resume GetById(int id)
        {
            return _resumeRepository.GetById(id);
        }
        public Resume GetByMin(string min)
        {
            return _resumeRepository.GetByMin(min);
        }
        public void Add(Resume r)
        {
            _resumeRepository.Add(r);
            _managerRepository.save();

        }
        public void UpdatePhon(int id, string phon)
        {
            _resumeRepository.UpdatePhon(id, phon);
            _managerRepository.save();

        }
        public void Delete(int id)
        {
            _resumeRepository.Delete(id);
            _managerRepository.save();

        }





    }
}



