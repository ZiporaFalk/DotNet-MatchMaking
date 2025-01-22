using Matchmaking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.DTOS
{
    public class MatchDto
    {
        public int MatchMakerId { get; set; }
        //public int IdM { get; set; }
        /// עמימות
        public int IdF { get; set; }
        public DateTime Date { get; set; }

    }
}
