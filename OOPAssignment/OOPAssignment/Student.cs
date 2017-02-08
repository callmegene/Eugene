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
    class Student : Ticket
    {
        public string LevelOfStudy { get; set; }
        public Student() { }
        public Student(Screening s, string l)
        {
            Screening = s;
            LevelOfStudy = l;
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
                            value = 8.0;
                    else
                        value = 14.0;
                }
                else if (Screening.ScreeningType == "2D Movies")
                {
                    if (Screening.ScreeningDateTime.DayOfWeek >= DayOfWeek.Monday && Screening.ScreeningDateTime.DayOfWeek <= DayOfWeek.Thursday)
                        if ((Screening.Movie.OpeningDateTime - Screening.ScreeningDateTime).TotalDays <= 7)
                            value = 8.5;
                        else
                            value = 7.0;
                    else
                        value = 12.5;
                }
                return value;
            }
        }
    }
}
