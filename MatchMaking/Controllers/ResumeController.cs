using AutoMapper;
using Matchmaking.Core.DTOS;
using Matchmaking.Core.Models;
using Matchmaking.Core.Services;
using Matchmaking.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Numerics;
//----------------------------------------ציפי------------------------------------------------------

namespace Matchmaking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeService _resumeService;
        private readonly IMapper _mapper;
        public ResumeController(IResumeService resumeService, IMapper mapper)
        {
            _resumeService = resumeService;
            _mapper = mapper;
        }
        //שליפת כל המועמדים                 
        [HttpGet]
        public async Task<IEnumerable<ResumeDto>> Get()
        {
            //   return _resumeService.GetAll();
            var listResumes = await _resumeService.GetAllAsync();
            var listResumesDto = _mapper.Map<IEnumerable<ResumeDto>>(listResumes);
            return listResumesDto;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            Resume resume = await _resumeService.GetByIdAsync(id);
            if (resume is null)
                return NotFound();
            var resumeDto = _mapper.Map<ResumeDto>(resume);
            return Ok(resumeDto);
        }
        //שליפת מועמד לפי מין          
        //[HttpGet("{min}")]
        //public async Task<ActionResult> Get(string min)
        //{
        //    Resume resume = await _resumeService.GetByMinAsync(min);
        //    if (resume is null)
        //        return NotFound();
        //    var resumeDto = _mapper.Map<ResumeDto>(resume);
        //    return Ok(resumeDto);
        //}
        //הוספת מועמד חדש                   
        [HttpPost]
        public void Post([FromBody] ResumeDto c)
        {
            var resume = _mapper.Map<Resume>(c);
            _resumeService.Add(resume);
        }
        //עדכון מועמד (סמינר
        //לשאול אם אני רוצה לעשכן כל פעם מאפיין אחר
        [HttpPut("{id}")]
        [HttpPost("Update Phone")]
        public void Put(int id, [FromBody] string phone)
        {
            _resumeService.UpdatePhon(id, phone);
        }
        //מחיקת מועמד                          
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _resumeService.Delete(id);
        }
    }
}
