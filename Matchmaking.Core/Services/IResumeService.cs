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
        List<Resume> GetAll();

        Resume GetById(int id);

        Resume GetByMin(string min);

        void Add(Resume r);

        void UpdatePhon(int id, string phon);

        void Delete(int id);


    }
}
