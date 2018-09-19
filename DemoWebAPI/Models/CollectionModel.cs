using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Models
{
    public class CollectionModel
    {
        public int count { get; set; }
        public bool Success { get; set; }
        public List<ResultsCollection> Result { get; set; }
        public string Message { get; set; }
    }
    public class ResultsCollection
    {
        public string Heading { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string SubHeading { get; set; }
    }
}