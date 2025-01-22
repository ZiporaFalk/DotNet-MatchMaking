using Matchmaking.Core.Repositories;
using Matchmaking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Data.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly DataContext _context;
        public IResumeRepository Resumes { get; }
        public IMatchMakerRepository matchmakers { get; }
        public IMeetingRepository meetings { get; }
        public IMatchRepository matches { get; }

        public ManagerRepository(DataContext context, IResumeRepository resumeRepository, IMeetingRepository meetingRepository, IMatchMakerRepository matchMakerRepository, IMatchRepository matches)
        {
            _context = context;
            Resumes = resumeRepository;
            meetings = meetingRepository;
            matchmakers = matchMakerRepository;
            this.matches = matches;
        }
        public void save()
        {
            _context.SaveChanges();
            Console.WriteLine("amen!!!!!!!!!!!!!!!!!!!!!!!!");
        }


    }
}
