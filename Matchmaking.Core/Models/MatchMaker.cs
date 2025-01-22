using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Models
{
    public class MatchMaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public List<Match> Matches { get; set; }

        public MatchMaker()
        {

        }

        public MatchMaker(int id, string name, string phone, double price, List<Match> matches)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Price = price;
            Matches = matches;
        }
    }
}
