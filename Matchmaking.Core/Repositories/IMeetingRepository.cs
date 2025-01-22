using Matchmaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Repositories
{
    public interface IMeetingRepository
    {
        List<Meeting> GetList();

        Meeting GetById(int id);
        //Meeting GetByIdResume(int id);

        void Add(Meeting m);

        void UpdatePlaace(int id, string place);

        void Delete(int id);

    }
}
