using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Core.Models
{
    public class Resume
    {
        public int Id { get; set; }
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
        public Match MyMatch { get; set; }
        public Resume()
        {

        }
        public Resume(int id, string name, string min, int age, int heigth, string phone, string Status, string address, string studiesSubject, string educationalInstitution, Match MyMatch, int matchId)//
        {
            Id = id;
            Name = name;
            Min = min;
            Age = age;
            Heigth = heigth;
            Phone = phone;
            Address = address;
            this.Status = Status;
            StudiesSubject = studiesSubject;
            EducationalInstitution = educationalInstitution;
            this.MyMatch = MyMatch;
            MatchId = matchId;
        }


    }
}
