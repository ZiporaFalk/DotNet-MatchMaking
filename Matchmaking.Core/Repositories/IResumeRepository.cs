using Matchmaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Repositories
{
    public interface IResumeRepository
    {
        List<Resume> GetList();
        Resume GetById(int id);
        Resume GetByMin(string min);
        void Add(Resume r);
        void UpdatePhon(int id, string phon);
        void Delete(int id);


    }
}
