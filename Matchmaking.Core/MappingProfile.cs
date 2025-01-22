using AutoMapper;
using Matchmaking.Core.DTOS;
using Matchmaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Resume, ResumeDto>().ReverseMap();
            CreateMap<Match, MatchDto>().ReverseMap();
            CreateMap<Meeting, MeetingDto>().ReverseMap();
            CreateMap<MatchMaker, MatchmakerDto>().ReverseMap();

        }
    }
}
