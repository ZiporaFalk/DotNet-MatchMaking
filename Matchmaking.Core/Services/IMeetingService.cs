using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Services
{
    public interface IMeetingService
    {
        List<Meeting> GetAll();

        Meeting GetById(int id);
        //Meeting GetByIdResume(int id);

        void Add(Meeting meeting);

        void UpdatePlace(int id, string place);

        void Delete(int id);


    }
}
