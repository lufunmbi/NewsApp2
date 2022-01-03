using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp2
{
    public class LatestNewsModel
    {
        public class SearchResponseModel
        {
            public string status { get; set; }
            public int totalResults { get; set; }
            public List<resultsObj> results { get; set; }
        }
        public class resultsObj
        {
            public string title { get; set; }
            public string link { get; set; }
            public object keywords { get; set; }
            public List<string> creator { get; set; }
            public object video_url { get; set; }
            public string description { get; set; }
            public object content { get; set; }
            public string pubDate { get; set; }
            public string image_url { get; set; }
            public string source_id { get; set; }
        }
    }
}
}
