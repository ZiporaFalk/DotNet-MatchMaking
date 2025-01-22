//using Matchmaking.Api;
//using Matchmaking.Api.Controllers;
//using Matchmaking.Core;
//using Matchmaking.Core.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace UnitTests
//{
//    public class ResumeControllerTests
//    {
//        private readonly IDataContext _context; 
//        public ResumeControllerTests()
//        {
//            FakeContext f=new FakeContext();
//            _context = f;
//        }
//        [Fact]
//        public void GetAll_returnListOfResume()
//        {
//            //act
//            var controller = new ResumeController(new FakeContext());
//            var result = controller.Get();
//            //assert
//            Assert.IsType<List<Resume>>(result);
//        }
//        [Fact]
//        public void GetById_returnsOk()
//        {
//            var id = 1;
//            var controller = new ResumeController(new FakeContext());
//            var result = controller.Get(id);
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void GetById_returnsNotFound()
//        {
//            var id = 5;
//            var controller = new ResumeController(new FakeContext());
//            var result = controller.Get(id);
//            Assert.IsType<NotFoundResult>(result);
//        }
//    }
//}
