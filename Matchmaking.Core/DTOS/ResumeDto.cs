using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.DTOS
{
    public class ResumeDto
    {
        public string Name { get; set; }
        public string Min { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public int Heigth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string StudiesSubject { get; set; }
        public string EducationalInstitution { get; set; }
        public int MatchId { get; set; }
    }
}
