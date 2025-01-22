using AutoMapper;
using Matchmaking.Core.DTOS;
using Matchmaking.Core.Models;
using Matchmaking.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;


namespace Matchmaking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchMakerController : ControllerBase
    {
        private readonly IMatchMakerService _matchMakerService;
        private readonly IMapper _mapper;

        public MatchMakerController(IMatchMakerService matchMakerService, IMapper mapper)
        {
            _matchMakerService = matchMakerService;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<MatchMaker> Get()
        {
            return _matchMakerService.GetAll();
        }

        [HttpGet("Id")]
        public MatchmakerDto Get(int Id)
        {
            var matchmaker = _matchMakerService.GetById(Id);
            var matchmakerDto = _mapper.Map<MatchmakerDto>(matchmaker);
            return matchmakerDto;
        }

        [HttpGet("Name")]
        public MatchmakerDto Get(string name)
        {
            var matchmaker = _matchMakerService.GetByName(name);
            var matchmakerDto = _mapper.Map<MatchmakerDto>(matchmaker);
            return matchmakerDto;
        }
        //הוספת שדכן
        [HttpPost]
        public void Post([FromBody] MatchmakerDto m)
        {
            var matchmakerDto = _mapper.Map<MatchMaker>(m);
            _matchMakerService.Add(matchmakerDto);
        }

        //עדכון מחיר לשדכן
        [HttpPut("{id}/{price}")]
        public void Put(int id, int price)
        {
            _matchMakerService.UpdatePrice(id, price);
        }
        //מחיקת שדכן
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _matchMakerService.Delete(id);
        }
    }
}
