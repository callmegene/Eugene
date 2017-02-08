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
    class Adult : Ticket
    {
        public bool PopcornOffer { get; set; }

        public Adult() { }
        public Adult(Screening s, bool p)        
        {
            Screening = s;
            PopcornOffer = p;
        }
        public override double CalculatePrice()
        {
            double value = 0;
            if (Screening.ScreeningType == "3D Movies")
            {

                    if (Screening.ScreeningDateTime.DayOfWeek >= DayOfWeek.Monday && Screening.ScreeningDateTime.DayOfWeek <= DayOfWeek.Thursday)
                        value = 11.0;
                    else
                        value = 14.0;                
            }
            else if (Screening.ScreeningType == "2D Movies")
            {

                    if (Screening.ScreeningDateTime.DayOfWeek >= DayOfWeek.Monday && Screening.ScreeningDateTime.DayOfWeek <= DayOfWeek.Thursday)
                        value = 8.50;
                    else
                        value = 12.5;
            }
            return value;
        }
    }
}
