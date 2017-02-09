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
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();
            List<Screening> ScreeningList = new List<Screening>();
            List<CinemaHall> CinemaList = new List<CinemaHall>();
            initMovie(MovieList);
            initCinemaHall(CinemaList);
            initScreening(ScreeningList, CinemaList, MovieList);

            /**While loop**/
            while (true)
            {
                /**Exception handling**/
                try
                {
                    Console.WriteLine("");
                    Menu();
                    Console.WriteLine("");
                    Console.Write("Enter option: ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    if (no == 1)
                    { Console.WriteLine("Option 1. List All Movie\n"); Option1(MovieList); }
                    else if (no == 2)
                    { Console.WriteLine("Option 2. Add Movie Screening"); Option2(CinemaList, MovieList, ScreeningList); }
                    else if (no == 3)
                    {
                        Console.WriteLine("Option 3. List Movie Screening"); option3(MovieList, ScreeningList);
                    }
                    else if (no == 4)
                    {
                        Console.WriteLine("Option 4. Delete Movie Screening"); option4(ScreeningList);
                    }
                    else if (no == 5)
                    {
                        Console.WriteLine("Option 5. Order Movie Tickets"); option5(MovieList, CinemaList, ScreeningList);
                    }
                    else if (no == 6)
                    {
                        Console.WriteLine("Option 6. Add Movie Rating"); option6(MovieList);
                    }
                    else if (no == 7)
                    {
                        Console.WriteLine("Option 7. View Movie Ratings and Comments"); option7(MovieList);
                    }
                    else if (no == 8)
                    {
                        Console.WriteLine("Option 8. Recommend movie"); option8(MovieList);
                    }
                    else if (no == 0)
                    {
                        Console.WriteLine("Enter any exit to exit"); Console.ReadKey(); break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid value");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }


        }
        /**Menu method**/
        static void Menu()
        {
            Console.WriteLine("\tMovie Ticketing System");
            Console.WriteLine("=================================");
            Console.WriteLine("1. List all movies");
            Console.WriteLine("2. Add a movie screening session");
            Console.WriteLine("3. List movie screenings");
            Console.WriteLine("4. Delete a movie screening session");
            Console.WriteLine("5. Order movie ticket/s");
            Console.WriteLine("6  Add a movie rating");
            Console.WriteLine("7. View movie ratings and comments");
            Console.WriteLine("8. Recommend movies");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=================================");
        }
        /**Creating of movie List**/
        static void initMovie(List<Movie> MovieList)
        {
            DateTime date = new DateTime(2016, 12, 29);
            List<string> G1 = new List<string> { "Action", "Adventure" }; Movie m = new Movie("The Great Wall", 103, "NC16", date, G1, new List<string>(), new List<double>()); MovieList.Add(m);

            DateTime date1 = new DateTime(2016, 12, 15);
            List<string> G2 = new List<string> { "Action", "Adventure" }; m = new Movie("Rouge One: Star Wars Story", 134, "PG13", date1, G2, new List<string>(), new List<double>()); MovieList.Add(m);


            DateTime date2 = new DateTime(2017, 01, 15);
            List<string> G3 = new List<string> { "Comedy" }; m = new Movie("Office Christmas Party", 106, "M18", date2, G3, new List<string>(), new List<double>()); MovieList.Add(m);


            DateTime date3 = new DateTime(2017, 01, 31);
            List<string> G4 = new List<string> { "Fantasy", "Thriller" }; m = new Movie("Power Rangers", 120, "G", date3, G4, new List<string>(), new List<double>()); MovieList.Add(m);
        }
        /**Creating of screening list**/
        static void initScreening(List<Screening> ScreeningList, List<CinemaHall> CinemaList, List<Movie> MovieList)
        {
            Screening s;
            DateTime d1 = new DateTime(2016, 12, 29, 15, 00, 00); CinemaHall c = CinemaList[2]; Movie m = MovieList[0];
            s = new Screening(d1, "3D", c, m); ScreeningList.Add(s);

            DateTime d2 = new DateTime(2017, 01, 03, 13, 00, 00); c = CinemaList[3]; m = MovieList[1];
            s = new Screening(d2, "2D", c, m); ScreeningList.Add(s);

            DateTime d3 = new DateTime(2017, 01, 31, 19, 00, 00); c = CinemaList[0]; m = MovieList[3];
            s = new Screening(d3, "3D", c, m); ScreeningList.Add(s);

            DateTime d4 = new DateTime(2017, 02, 02, 15, 00, 00); c = CinemaList[1]; m = MovieList[3];
            s = new Screening(d4, "2D", c, m); ScreeningList.Add(s);
        }
        /**Creating of Cinema List**/
        static void initCinemaHall(List<CinemaHall> CinemaList)
        {
            CinemaHall c;
            c = new CinemaHall("Singa North", 1, 30); CinemaList.Add(c);
            c = new CinemaHall("Singa North", 2, 10); CinemaList.Add(c);
            c = new CinemaHall("Singa West", 1, 50); CinemaList.Add(c);
            c = new CinemaHall("Singa East", 1, 5); CinemaList.Add(c);
            c = new CinemaHall("Singa Central", 1, 20); CinemaList.Add(c);
            c = new CinemaHall("Singa Central", 2, 15); CinemaList.Add(c);
        }
        /**Option 1 method
         * 
         * DIsplay movie list**/
        static void Option1(List<Movie> MovieList)
        {
            Console.WriteLine("{0,-4}{1,-27}{2,-9}{3,-20}{4,-15}{5,-20}", "No", "Title", "Duration", "Genre", "Classification", "Opening Date");
            for (int i = 0; i < MovieList.Count; i++)
            {
                Movie m = MovieList[i];
                Console.WriteLine("{0,-4}{1,-27}{2,-9}{3,-20}{4,-15}{5,-20}", (i + 1), m.Title, m.Duration, string.Join(", ", m.GetGenreList()), m.classification, m.OpeningDateTime);
            }
        }
        /**Option 2 method
         * 
         * Add a movie screening session**/
        static void Option2(List<CinemaHall> CinemaList, List<Movie> MovieList, List<Screening> ScreeningList)
        {

            CinemaHall c;
            Console.WriteLine("{0,-4}{1,-20}{2,-15}{3,-20}", "No", "Cinema Name", "Hall No", "Capacity");
            for (int i = 0; i < CinemaList.Count; i++)
            {
                c = CinemaList[i];
                Console.WriteLine("{0,-4}{1,-20}{2,-15}{3,-20}", (i + 1), c.Name, c.HallNo, c.Capacity);
            }
            Console.Write("Select a cinema hall: ");
            int hallno = Convert.ToInt32(Console.ReadLine());
            if (hallno > CinemaList.Count || hallno < 0)
            {
                throw new Exception("\nHall number must be within index");
            }
            Option1(MovieList);
            Console.Write("Select a movie: ");
            int movieno = Convert.ToInt32(Console.ReadLine());
            if (movieno > MovieList.Count || movieno < 0)
            {
                throw new Exception("\nMovie number must be within index");
            }
            Console.WriteLine("");
            Console.Write("Select a screening type [2D/3D]:");
            string screeningtype = Console.ReadLine();
            if (screeningtype != "2D" && screeningtype != "3D")
            {
                throw new Exception("\nScreening type must either be 2D or 3D");
            }
            Console.Write("Enter a screening date and time [e.g DD/MM/YYYY HH:MM]: ");
            DateTime dat = Convert.ToDateTime(Console.ReadLine());
            if (dat < MovieList[movieno - 1].OpeningDateTime)
            {
                throw new Exception("\nUnable add screening: Date is before opening");
            }
            Movie m = MovieList[movieno - 1];
            c = CinemaList[hallno - 1];
            Screening s = new Screening(dat, screeningtype, c, m);
            ScreeningList.Add(s);
            Console.WriteLine("Movie Screening successfully created.");
        }
        /**Option 3 method
         * List movie screenings**/
        static void option3(List<Movie> MovieList, List<Screening> ScreeningList)
        {
            Option1(MovieList);
            Console.Write("Select a movie: ");
            int movieno = Convert.ToInt32(Console.ReadLine());
            if (movieno > MovieList.Count || movieno < 0)
            {
                throw new Exception("\nMovie number must be within index");
            }
            Console.WriteLine("\n");
            Console.WriteLine("{0,-13}{1,-10}{2,-25}{3,-17}", "Location", "Type", "Date/Time", "Seats remaining");
            bool check = false;
            for (int i = 0; i < ScreeningList.Count; i++)
            {
                Screening s = ScreeningList[i];
                if (s.Movie.Title == MovieList[movieno - 1].Title)
                {
                    Console.WriteLine("{0,-13}{1,-10}{2,-25}{3,-17}", s.CinemaHall.Name, s.ScreeningType, s.ScreeningDateTime, s.CinemaHall.Capacity);
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("{0,-13}{1,-10}{2,-25}{3,-17}", "Nil", "Nil", "Nil", "Nil", "Nil");
            }
        }
        /**Option 4 method
         * Delete movie screenings**/
        static void option4(List<Screening> ScreeningList)
        {

            Console.WriteLine("");
            Console.WriteLine("{0,-6}{1,-12}{2,-10}{3,-28}{4,-20}", "No", "Location", "Hall No", "Title", "Date/Time");
            for (int i = 0; i < ScreeningList.Count; i++)
            {
                Screening s = ScreeningList[i];
                if (s.SeatsRemaining == s.CinemaHall.Capacity)
                {
                    Console.WriteLine("{0,-6}{1,-12}{2,-10}{3,-28}{4,-20}", s.ScreeningNo, s.CinemaHall.Name, s.CinemaHall.HallNo, s.Movie.Title, s.ScreeningDateTime);
                }
            }
            Console.Write("Enter a screening number to delete: ");
            string delno = Console.ReadLine();
            bool check = false;
            for (int i = 0; i < ScreeningList.Count; i++)
            {
                if (ScreeningList[i].ScreeningNo == delno)
                {
                    ScreeningList.RemoveAt(i);
                    Console.WriteLine("\nScreening deleted.");
                    check = true;
                }
            }
            if (check == false)
                Console.WriteLine("Screening number is incorrect");
        }

        /**Option 5 method
         * Order movie ticket**/
        static void option5(List<Movie> MovieList, List<CinemaHall> CinemaHallList, List<Screening> ScreeningList)
        {
            Order ord = new Order();
            Screening s = null;
            double total = 0;
            Option1(MovieList);
            Console.Write("Select a movie : ");
            int movieno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0,-6}{1,-12}{2,-18}{3,-24}{4,-30}", "No", "Location", "Hall No", "Date/Time", "Seats Remaining");
            for (int i = 0; i < ScreeningList.Count; i++)
            {
                if (ScreeningList[i].Movie.Title == MovieList[movieno - 1].Title)
                {
                    s = ScreeningList[i];
                    Console.WriteLine("{0,-6}{1,-12}{2,-18}{3,-24}{4,-30}", s.ScreeningNo, s.CinemaHall.Name, s.CinemaHall.HallNo, s.ScreeningDateTime, s.SeatsRemaining);
                }
            }
            int sessionno = 0;
            bool check = false;
            while (check == false)
            {
                Console.Write("Select a session : ");
                sessionno = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ScreeningList.Count; i++)
                {
                    s = ScreeningList[i];
                    if (s.ScreeningNo == Convert.ToString(sessionno))
                    {
                        s = ScreeningList[i];
                        break;
                    }
                }
                for (int i = 0; i < ScreeningList.Count; i++)
                {
                    if (s.Movie.Title != MovieList[movieno - 1].Title)
                        check = false;
                    else
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                    Console.WriteLine("Invalid screening in select movie, please try again");
            }
            Console.Write("Please enter number of tickets you wish to purchase: ");
            int tickno = Convert.ToInt32(Console.ReadLine());
            while (tickno > s.CinemaHall.Capacity)
            {
                Console.WriteLine("Ticket number is more than seats remainding, please try again");
                Console.Write("Please enter number of tickets you wish to purchase: ");
                tickno = Convert.ToInt32(Console.ReadLine());
            }
            if (MovieList[movieno - 1].classification == "M18" || MovieList[movieno - 1].classification == "NC16" || MovieList[movieno - 1].classification == "PG13" || MovieList[movieno - 1].classification == "R21")
            {
                Console.Write("The movie classification is " + MovieList[movieno - 1].classification + ". Does every ticket holder meet the age requirements [Y/N]?");
            }
            string req = Console.ReadLine();
            string ticktype = "";
            ord.status = "Unpaid";
            if (req == "Y" || req == "y" || MovieList[movieno - 1].classification == "G")
            {

                for (int i = 1; i <= tickno; i++)
                {
                    Console.WriteLine("Ticket #" + i);
                    bool checktype = false;
                    while (checktype == false)
                    {
                        Console.Write("Type of ticket to purchase [Student/Senior/Adult] : ");
                        ticktype = Console.ReadLine();
                        if (ticktype == "senior" || ticktype == "Senior" || ticktype == "adult" || ticktype == "Adult" || ticktype == "student" || ticktype == "Student")
                            checktype = true;
                        else
                            Console.WriteLine("Incorrect input, please try again");
                    }
                    if (ticktype == "Senior" || ticktype == "senior")
                    {
                        bool checkage = false;
                        while (checkage == false)
                        {
                            Console.Write("Please enter year of birth [YYYY]: ");
                            int year = Convert.ToInt32(Console.ReadLine());
                            if ((DateTime.Now.Year - year) >= 55)
                            {
                                Ticket tick = new SeniorCitizen(ScreeningList[sessionno - 1001], year);
                                Console.WriteLine("Ticket #" + i + " ordered successfully.");
                                total += tick.CalculatePrice();
                                checkage = true;
                            }
                            else
                                Console.WriteLine("Senior citizen age must be 55 and above, please try again");
                        }
                    }
                    else if (ticktype == "Student" || ticktype == "student")
                    {
                        string level = "";
                        bool checklevel = false;
                        while (checklevel == false)
                        {
                            Console.Write("Please enter level of study [Primary/Secondary/tertiary]: ");
                            level = Console.ReadLine();
                            if (level == "primary" || level == "Primary" || level == "secondary" || level == "Secondary" || level == "tertiary" || level == "Tertiary")
                                checklevel = true;
                            else
                                Console.WriteLine("Incorrect input, please try again");
                        }
                        Ticket tick = (new Student(ScreeningList[sessionno - 1001], level));
                        Console.WriteLine("Ticket #" + i + " ordered successfully.");
                        total += tick.CalculatePrice();
                    }
                    else if (ticktype == "Adult" || ticktype == "adult")
                    {
                        bool popcornstring = false;
                        while (popcornstring == false)
                        {
                            Console.Write("Do you want to buy popcorn for $3? [Y/N]");
                            string popcorn = Console.ReadLine();
                            if (popcorn == "Y" || popcorn == "y")
                            {

                                Ticket tick = (new Adult(ScreeningList[sessionno - 1001], true));
                                Console.WriteLine("Ticket #" + i + " ordered successfully.");
                                total += ((tick.CalculatePrice() + 3));
                                popcornstring = true;
                            }
                            else if (popcorn == "N" || popcorn == "n")
                            {
                                Ticket tick = (new Adult(ScreeningList[sessionno - 1001], false));
                                Console.WriteLine("Ticket #" + i + " ordered successfully.");
                                total += tick.CalculatePrice();
                                popcornstring = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter either Y or N");
                            }
                        }
                    }
                    s.SeatsRemaining -= 1;
                    ord.Amount = total;
                }
                Console.WriteLine("Order #" + Order.OrderCount);
                Console.WriteLine("==========");
                Console.WriteLine("Movie title : " + s.Movie.Title);
                Console.WriteLine("Cinema : " + s.CinemaHall.Name);
                Console.WriteLine("Hall : " + s.CinemaHall.HallNo);
                Console.WriteLine("Date/Time : " + s.ScreeningDateTime);
                Console.WriteLine("Total : $" + ord.Amount);
                Console.WriteLine("==========");
                Console.WriteLine("Press any key to make payment");
                Console.ReadKey();
                ord.status = "Paid";
                Console.WriteLine("Thanks you for visiting Singa Cineplexes. Have a great movie!");
            }
            else
                throw new Exception("Sorry, the ticket holder must meet the age requirement.");
        }
        /**Option 6 method
         * Add movie rating**/
        static void option6(List<Movie> MovieList)
        {
            Option1(MovieList);
            Console.Write("\nEnter movie number to review the movie: ");
            int movieno = Convert.ToInt32(Console.ReadLine());
            Movie m = MovieList[movieno - 1];
            double total = 0;
            for (int i = 0; i < m.GetRateList().Count; i++)
            {
                total += m.GetRateList()[i];
            }
            double avg = 0;

            if (m.GetRateList().Count > 0)
            {
                avg = total / m.GetRateList().Count;
                Console.WriteLine("The current rating for " + m.Title + " is {0:.00}", avg);
            }
            else
                Console.WriteLine("The current rating for " + m.Title + " is " + avg);
            bool check = false;
            int rate = 0;
            while (check == false)
            {
                Console.Write("\nPlease enter a rating [0=Very bad; 5=Very good]: ");
                rate = Convert.ToInt32(Console.ReadLine());
                if (rate >= 0 && rate <= 5)
                {
                    check = true;
                    break;
                }
                else
                    Console.WriteLine("Please enter a valid value between 0 and 5");
            }
            m.GetRateList().Add(rate);
            Console.Write("Please enter comments about the movie: ");
            string ratingcomment = Console.ReadLine();
            m.GetRatingCmts().Add(ratingcomment);
            Console.WriteLine("Thank you for the submission");
            total = 0;
            for (int i = 0; i < m.GetRateList().Count; i++)
            {
                total += m.GetRateList()[i];
            }
            avg = total / m.GetRateList().Count;
            if (total > 0)
                Console.WriteLine("The new rating for the movie is {0:.00}", avg);
            else
                Console.WriteLine("The new rating for the movie is 0");
        }
        /**Option 7 method
         * View movie ratings and comments**/
        static void option7(List<Movie> MovieList)
        {
            Option1(MovieList);
            Console.Write("Select a movie: ");
            int movieno = Convert.ToInt32(Console.ReadLine());
            Movie m = MovieList[movieno - 1];
            if (m.GetRateList().Count > 0)
            {
                double total = 0;
                for (int i = 0; i < m.GetRateList().Count; i++)
                {
                    total += m.GetRateList()[i];
                }
                double avg = (total / m.GetRateList().Count);
                Console.WriteLine("\nThe rating for " + m.Title + " is {0:.00}", avg);
                for (int i = 0; i < m.GetRatingCmts().Count; i++)
                    Console.WriteLine("Comment #" + (i + 1) + " " + m.GetRatingCmts()[i]);
            }
            else
                Console.WriteLine("\nThere are no ratings or comments for " + m.Title + " yet.");
        }
        /**Option 8 method
         * Recommend a movie(e.g, based on rating, genre, classification, price**/
        static void option8(List<Movie> MovieList)
        {
            while (true)
            {               
                Console.WriteLine("\nRecommandations menu\n");
                Console.WriteLine("[1] Recommand me a movie by ratings.");
                Console.WriteLine("[2] Recommand me a movie by genre.");
                Console.WriteLine("[3] Recommand me a movie by classification.");
                Console.WriteLine("[4] Recommand me a movie by location");
                Console.WriteLine("[5] Take a look at people's comments on the movie");
                Console.WriteLine("[0] Exit recommandations menu");
                Console.Write("\nChoose an option: ");
                int no = Convert.ToInt32(Console.ReadLine());
                if (no == 1)
                { Console.WriteLine("\nRecommand a movie by rating selected"); option81(MovieList); }
                else if (no == 2)
                { Console.WriteLine("\nRecommand a movie by genre with the higher rating"); option82(MovieList); }
            }
        }
        static void option81(List<Movie>MovieList)
        {
            double average;
            double highest = 0;
            int value = -1;
            for (int i = 0; i < MovieList.Count; i++)
            {
                Movie m = MovieList[i];
                average = (m.GetRateList().Sum() / m.GetRateList().Count);
                if (average > highest)
                {
                    highest = average;
                    value = i;
                }               
            }
            if (value == -1)
                Console.WriteLine("Sorry, none of the movie has a rating yet");
            else
                Console.WriteLine("The movie with the highest rating is " + MovieList[value].Title + " with a rating of " +highest+"." );                
        }
        static void option82(List<Movie> MovieList)
        {
            Movie m;            
            Console.Write("Please select a genre [Action/Comedy/Adventure/Fantasy/Thriller]: ");
            string picked = Console.ReadLine();
            Console.WriteLine("The movie with the genre, " + picked + ", is/are");
            for (int i = 0;i<MovieList.Count;i++)
            {
                bool inside = false;
                m = MovieList[i];
                if (inside == false)
                {
                    for (int x = 0; x < m.GetGenreList().Count; x++)
                    {
                        if (m.GetGenreList()[x] == picked)
                        {
                            inside = true;                            
                            Console.WriteLine("- " + m.Title);                            
                        }
                    }
                }
            }
        }
        static void option83()
        {

        }
        static void option84()
        {

        }      
    }            
}
