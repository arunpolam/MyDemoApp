using DemoWebAPI.Interfaces;
using DemoWebAPI.Models;
using DemoWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    public class DemoAPIController : ApiController
    {

        private readonly ResultsRepository _repo;
        public DemoAPIController()
        {
            _repo = new ResultsRepository();
        }
        
        // add the GET attribute to support RESTful API to GET current string - this case Hello World
        //[HttpGet]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}

        [HttpGet]
        public CollectionModel GetResults()
        {
            var results = _repo.GetResults();
            return results;
        }
    }
}
