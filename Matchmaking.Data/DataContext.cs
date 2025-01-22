using Matchmaking.Core;
using Matchmaking.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Meeting> meetings { get; set; }
        public DbSet<MatchMaker> matchmakers { get; set; }
        public DbSet<Match> matches { get; set; }
        //public DataContext()
        //{
        //    Resumes = new List<Resume>()
        //    { new Resume{Id=1,Name="Lea Coen",Min="2",Address="chazon ish" ,Phone="0533145728" },
        //     new Resume{Id=2,Name="riki kraus",Min = "2",Address="Lando" ,Phone="0527176658" },
        //     new Resume{Id=3,Name="zipi gold",Min="2",Address="Jerusalem" ,Phone="0533145728" }};

        //    meetings = new List<Meeting>()
        //    { new Meeting{Id=300,IdM=1,IdF=3,Datemeeting=new DateTime(2024,2,20) ,IdMatchMaker=21,NumMeeting=1,Placemeeting="Park-Aleumi"},
        //     new Meeting{Id=301,IdM=2,IdF=6,Datemeeting=new DateTime(2024 ,2,8) ,IdMatchMaker=24,NumMeeting=4,Placemeeting="Park-Aleumi"},
        //    new Meeting{Id=302,IdM=1,IdF=5,Datemeeting=new DateTime(2024,5, 16) ,IdMatchMaker=23,NumMeeting=2,Placemeeting="cfar-hamacabia"}};

        //    matchmakers = new List<MatchMaker>()
        //    { new MatchMaker{Id=20,Name="chaim cohen",Phone="0548485695",Price=4000 },
        //    new MatchMaker{Id=21,Name="yossef levi",Phone="054844785",Price=5000 },
        //    new MatchMaker{Id=22,Name="leha kostelitz",Phone="0548454545",Price=8000 }};
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }

        //public DataContext(DbContextOptions<DataContext> options): base(options) { } 


    }
}
