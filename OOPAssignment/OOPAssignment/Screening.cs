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
    class Screening
    {
        private static int ScreeningCount = 1001;
        public string ScreeningNo { get; set; }
        public DateTime ScreeningDateTime { get; set; }
        public string ScreeningType { get; set; }
        public int SeatsRemaining { get; set; }
        public CinemaHall CinemaHall { get; set; }
        public Movie Movie { get; set; }

        public Screening(){}
        public Screening(DateTime d,string s, CinemaHall c,Movie m)
        {
            ScreeningNo = Convert.ToString(ScreeningCount);
            ScreeningCount++;
            SeatsRemaining = c.Capacity;
            ScreeningDateTime = d;
            ScreeningType = s;
            CinemaHall = c;
            Movie = m;
        }
    }
}
