using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Services
{
    public interface IResumeService
    {
        Task<List<Resume>> GetAllAsync();

        Task<Resume> GetByIdAsync(int id);

        Task<Resume> GetByMinAsync(string min);
        void Add(Resume r);

        void UpdatePhon(int id, string phon);

        void Delete(int id);


    }
}
