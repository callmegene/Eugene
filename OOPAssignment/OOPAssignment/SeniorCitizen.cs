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
    class SeniorCitizen : Ticket
    {
        public int YearOfBirth { get; set; }

        public SeniorCitizen() { }
        public SeniorCitizen(Screening s, int y)
        {
            Screening = s;
            YearOfBirth = y;
        }

        public override double CalculatePrice()
        {
            {
                double value = 0;
                if (Screening.ScreeningType == "3D Movies")
                {

                    if (Screening.ScreeningDateTime.DayOfWeek >= DayOfWeek.Monday && Screening.ScreeningDateTime.DayOfWeek <= DayOfWeek.Thursday)
                        if ((Screening.Movie.OpeningDateTime - Screening.ScreeningDateTime).TotalDays <= 7)
                            value = 11.0;
                        else
                            value = 6.00;
                    else
                        value = 14.0;
                }
                else if (Screening.ScreeningType == "2D Movies")
                {

                    if (Screening.ScreeningDateTime.DayOfWeek >= DayOfWeek.Monday && Screening.ScreeningDateTime.DayOfWeek <= DayOfWeek.Thursday)
                        if ((Screening.Movie.OpeningDateTime - Screening.ScreeningDateTime).TotalDays <= 7)
                            value = 8.5;
                        else
                            value = 5.0;
                    else
                        value = 12.5;
                }
                return value;
            }
        }

    }
}
