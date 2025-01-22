//using Matchmaking.Api.Controllers;
//using Matchmaking.Api.Controllers;
//using Matchmaking.Core.Models;
//using Matchmaking.Core;

//namespace Matchmaking.Api
//{
//    public class FakeContext : IDataContext
//    {
//        public List<Resume> Resumes { get; set; }
//        public List<Meeting> meetings { get; set; }
//        public List<MatchMaker> matchmakers { get; set; }
//        public FakeContext()
//        {
//            Resumes = new List<Resume>()
//            { new Resume{Id=1,Name="Lea Coen",Address="chazon ish" ,Phone="0533145728" },
//             new Resume{Id=2,Name="riki kraus",Address="Lando" ,Phone="0527176658" },
//             new Resume{Id=3,Name="zipi gold",Address="Jerusalem" ,Phone="0533145728" }};



//            meetings = new List<Meeting>()
//            { new Meeting{Id=300,IdM=1,IdF=3,Datemeeting=new DateTime(2024,2,20) ,IdMatchMaker=21,NumMeeting=1,Placemeeting="Park-Aleumi"},
//             new Meeting{Id=301,IdM=2,IdF=6,Datemeeting=new DateTime(2024 ,2,8) ,IdMatchMaker=24,NumMeeting=4,Placemeeting="Park-Aleumi"},
//            new Meeting{Id=302,IdM=1,IdF=5,Datemeeting=new DateTime(2024,5, 16) ,IdMatchMaker=23,NumMeeting=2,Placemeeting="cfar-hamacabia"}};


//            matchmakers = new List<MatchMaker>()
//            { new MatchMaker{Id=20,Name="chaim cohen",Phone="0548485695",Price=4000 },
//            new MatchMaker{Id=21,Name="yossef levi",Phone="054844785",Price=5000 },
//            new MatchMaker{Id=22,Name="leha kostelitz",Phone="0548454545",Price=8000 }};
//        }
//    }
//}
