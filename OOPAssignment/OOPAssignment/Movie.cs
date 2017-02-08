using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//============================================================
//Student Number : S10175825D, S10175359D
//Student Name   : Jeff Lee  , Eugene Tan
//Module  Group  : IT06
//============================================================
namespace OOPAssignment
{
    class Movie
    {        
        public string Title { get; set; }
        public int Duration { get; set; }
        public string classification { get; set; }
        public DateTime OpeningDateTime { get; set; }
        public List<string>GenreList = new List<string>();
        public List<string> Ratingcmts = new List<string>();
        public List<double> Rates = new List<double>();

        public Movie() { }
        public Movie(string t,int d, string c,DateTime o,List<string> g,List<string>r,List<double>rts)
        {
            Title = t;
            Duration = d;
            classification = c;
            OpeningDateTime = o;
            GenreList = g;
            Ratingcmts = r;
            Rates = rts;
        }

        public List<string> GetGenreList()
        { return GenreList; }
    }
}
