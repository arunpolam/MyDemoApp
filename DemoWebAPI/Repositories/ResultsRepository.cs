using DemoWebAPI.Interfaces;
using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Repositories
{
    public class ResultsRepository : InterfaceDemoAPI
    {
        public CollectionModel GetResults()
        {
            var results = new CollectionModel();
            results.count = 100;
            results.Message = "API SUCCESSFULLY CALLED.";
            results.Success = true;
            return results;
        }
    }
}