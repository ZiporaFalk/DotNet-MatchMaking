using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Repositories
{
    public interface IManagerRepository
    {
        IResumeRepository Resumes { get; }
        IMatchMakerRepository matchmakers { get; }
        IMeetingRepository meetings { get; }
        IMatchRepository matches { get; }

        void save();
    }
}
