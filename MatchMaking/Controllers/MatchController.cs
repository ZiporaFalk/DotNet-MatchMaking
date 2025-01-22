using AutoMapper;
using Matchmaking.Core.DTOS;
using Matchmaking.Core.Models;
using Matchmaking.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Matchmaking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;
        private readonly IMapper _mapper;

        public MatchController(IMatchService matchService, IMapper mapper)
        {
            _matchService = matchService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<MatchDto> Get()
        {
            var matches = _matchService.GetAll();
            var matchesDto = _mapper.Map<IEnumerable<MatchDto>>(matches);
            return matchesDto;
        }

        [HttpGet("Id")]
        public MatchDto Get(int Id)
        {
            var match = _matchService.GetById(Id);
            var matchDto = _mapper.Map<MatchDto>(match);
            return matchDto;
        }

        [HttpGet("Date")]
        public MatchDto Get(DateTime date)
        {
            var match = _matchService.GetByDate(date);
            var matchDto = _mapper.Map<MatchDto>(match);
            return matchDto;
        }
        //הוספת שידוך
        [HttpPost]
        public void Post([FromBody] MatchDto m)
        {
            var match=_mapper.Map<Match>(m);
            _matchService.Add(match);
        }


        //מחיקת שידוך
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _matchService.Delete(id);
        }

    }
}
