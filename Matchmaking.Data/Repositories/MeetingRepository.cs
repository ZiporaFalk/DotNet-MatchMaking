using Matchmaking.Core;
using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Data.Repositories
{
    public class MeetingRepository:IMeetingRepository
    {
        private readonly DataContext _context;
        public MeetingRepository(DataContext context)
        {
            _context = context;
        }

        public List<Meeting> GetList()
        {
            return _context.meetings.ToList();
            //return _context.meetings.Include(m => m.Match).ToList();

        }
        public Meeting GetById(int id)
        {
            return _context.meetings.FirstOrDefault(x => x.Id == id);
        }
        //public Meeting GetByIdResume(int id)
        //{
        //    return _context.meetings.FirstOrDefault(x => x.IdM == id);
        //}
        public void Add(Meeting m)
        {
            _context.meetings.Add(m);
        }
        public void UpdatePlaace(int id, string place)
        {
            Meeting m = _context.meetings.FirstOrDefault(x => x.Id == id);
            m.Placemeeting = place;
        }
        public void Delete(int id)
        {
            Meeting m = _context.meetings.FirstOrDefault(x => x.Id == id);
            _context.meetings.Remove(m);
        }


    }
}
