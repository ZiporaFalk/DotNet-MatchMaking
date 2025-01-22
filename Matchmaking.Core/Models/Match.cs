using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int MatchMakerId { get; set; }
        public MatchMaker MatchMaker { get; set; }
        public Resume IdM { get; set; }
        /// עמימות
        public int IdF { get; set; }
        public List<Meeting> MyMeetings { get; set; }
        public DateTime Date { get; set; }

        public Match()
        {

        }
        public Match(int id, MatchMaker MatchMaker, Resume idM, int idF, List<Meeting> MyMeetings, DateTime date, int matchMakerId)
        {
            Id = id;
            this.MatchMaker = MatchMaker;
            IdM = idM;
            IdF = idF;
            this.MyMeetings = MyMeetings;
            Date = date;
            MatchMakerId = matchMakerId;
        }
    }
}
