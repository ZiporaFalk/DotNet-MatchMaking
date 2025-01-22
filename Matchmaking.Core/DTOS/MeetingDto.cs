using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.DTOS
{
    public class MeetingDto
    {
     //   public int Id { get; set; }
        public int MatchId { get; set; }
        public int NumMeeting { get; set; }
        public DateTime Datemeeting { get; set; }
        public string Placemeeting { get; set; }
    }
}
