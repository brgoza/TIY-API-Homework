using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Humanizer;

namespace Week8Day2.Models
{

    public class Result
    {
        //public int listing_id { get; set; }
        //public string state { get; set; }
        //public int user_id { get; set; }
        //public int category_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        //public int creation_tsz { get; set; }
        //public int ending_tsz { get; set; }
        //public int original_creation_tsz { get; set; }
        //public int last_modified_tsz { get; set; }
        public string price { get; set; }
        public MainImage MainImage { get; set; }
        public string prettyPrice => "$"+this.price.Humanize();

      public string url { get; set; }
        public int image_id { get; set; }
      
    }

    public class MainImage
    {
        public string url_170x135 { get; set; }
    }
    public class Results
    {
        public int count { get; set; }
        public List<Result> results { get; set; }
        public string type { get; set; }
    }
}

//}