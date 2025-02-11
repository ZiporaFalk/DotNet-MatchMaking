//using Matchmaking.Api.Interfaces;
using Matchmaking.Core.Models;
using Matchmaking.Core.Repositories;
using Matchmaking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Matchmaking.Data.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly DataContext _context;

        public ResumeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Resume>> GetListAsync()
        {
            return await _context.Resumes.ToListAsync();
        }
        public async Task<Resume> GetByIdAsync(int id)
        {
            return await _context.Resumes.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Resume> GetByMinAsync(string min)
        {
            return await _context.Resumes.FirstOrDefaultAsync(x => x.Min == min);
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




