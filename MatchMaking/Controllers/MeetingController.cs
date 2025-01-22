using AutoMapper;
using Matchmaking.Core.DTOS;
using Matchmaking.Core.Models;
using Matchmaking.Core.Services;
using Microsoft.AspNetCore.Mvc;


namespace Matchmaking.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        private readonly IMeetingService _meetingService;
        private readonly IMapper _mapper;


        public MeetingController(IMeetingService data, IMapper mapper)
        {
            _meetingService = data;
            _mapper = mapper;
        }
        //קבלת כל הפגישות
        [HttpGet]
        public IEnumerable<MeetingDto> Get()
        {
            var listmeeting = _meetingService.GetAll();
            var listmeetingsDto = _mapper.Map<IEnumerable<MeetingDto>>(listmeeting);
            return listmeetingsDto;
        }

        [HttpGet("Id")]
        public MeetingDto Get(int Id)
        {
            var meetingid = _meetingService.GetById(Id);
            var meetingDto = _mapper.Map<MeetingDto>(meetingid);
            return meetingDto;
        }

        //לשאול אם רוצים לעשות 2 get שמקבל int
        //[HttpGet("idresume")]
        //public Meeting Get(int idresume)
        //{
        //   return _meetingService.GetByIdResume(id);
        //}

        //הוספת פגישה
        [HttpPost]
        public void Post([FromBody] MeetingDto m)
        {
            var meeting = _mapper.Map<Meeting>(m);
            _meetingService.Add(meeting);
        }

        //עדכון מקום לפגישה
        [HttpPut("{id}/{place}")]
        public void Put(int id, string place)
        {
            _meetingService.UpdatePlace(id, place);
        }
        //מחיקת פגישה
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _meetingService.Delete(id);
        }

    }
}
