//using Matchmaking.Api.Interfaces;
using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using Matchmaking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Matchmaking.Data.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly DataContext _context;

        public ResumeRepository(DataContext context)
        {
            _context = context;
        }
        public List<Resume> GetList()
        {
            return _context.Resumes.ToList();
        }
        public Resume GetById(int id)
        {
            return _context.Resumes.FirstOrDefault(x => x.Id == id);
        }
        public Resume GetByMin(string min)
        {
            return _context.Resumes.FirstOrDefault(x => x.Min == min);
        }
        public void Add(Resume r)
        {
            _context.Resumes.Add(r);
        }
        public void UpdatePhon(int id, string phon)
        {
            Resume r = _context.Resumes.FirstOrDefault(x => x.Id == id);
            r.Phone = phon;
        }
        public void Delete(int id)
        {
            Resume r = _context.Resumes.FirstOrDefault(x => x.Id == id);
            _context.Resumes.Remove(r);
        }



    }
}




