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
            //The creation of all list in the main program
            List<Movie> MovieList = new List<Movie>();
            List<string> GenreList = new List<string>();
            List<Screening> ScreeningList = new List<Screening>();
            List<CinemaHall> CinemaList = new List<CinemaHall>();
            List<Order> OrderList = new List<Order>();
            List<string> Ratingcmts = new List<string>();
            List<double> Rates = new List<double>();
            initMovie(GenreList, MovieList,Ratingcmts,Rates);
            initCinemaHall(CinemaList);
            initScreening(ScreeningList, CinemaList, MovieList);

            /**While loop**/
            while (true)
            {
                /**Exception handling**/
                try
                {
                    //Calling individual methods with a condtion
                    Console.WriteLine("");
                    Menu();
                    Console.WriteLine("");
                    //Prompts the user for a option number
                    Console.Write("Enter option: ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    if (no == 1)
                    { Console.WriteLine("Option 1. List All Movie\n"); Option1(GenreList, MovieList); }
                    else if (no == 2)
                    { Console.WriteLine("Option 2. Add Movie Screening"); Option2(CinemaList, MovieList, GenreList, ScreeningList); }
                    else if (no == 3)
                    {
                        Console.WriteLine("Option 3. List Movie Screening"); option3(GenreList, MovieList, ScreeningList);
                    }
                    else if (no == 4)
                    {
                        Console.WriteLine("Option 4. Delete Movie Screening"); option4(ScreeningList);
                    }
                    else if (no == 5)
                    {
                        Console.WriteLine("Option 5. Order Movie Tickets"); option5(GenreList, MovieList, CinemaList, ScreeningList, OrderList);
                    }
                    else if (no == 6)
                    {
                        Console.WriteLine("Option 6. Add Movie Rating"); option6(MovieList,GenreList);
                    }
                    else if (no == 7)
                    {
                        Console.WriteLine("Option 7. View Movie Ratings and Comments"); option7(MovieList, GenreList);
                    }
                    else if (no == 8)
                    {
                        Console.WriteLine("Option 8. Recommend movie"); option8(GenreList, MovieList, Ratingcmts, Rates);
                    }
                    else if (no == 0)
                    {
                        Console.WriteLine("Enter any exit to exit"); Console.ReadKey(); break;
                    }
                    
                }
                catch (Exception ex)
                {
                    //The message that will be displayed after an invalid value is input
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please input a valid value");
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
        static void initMovie(List<string> GenreList, List<Movie> MovieList, List<string> Ratingcmts, List<double> Rates)
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
        static void Option1(List<string> GenreList, List<Movie> MovieList)
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
        static void Option2(List<CinemaHall> CinemaList, List<Movie> MovieList, List<string> GenreList, List<Screening> ScreeningList)
        {

                CinemaHall c;
                Console.WriteLine("{0,-4}{1,-20}{2,-15}{3,-20}", "No", "Cinema Name", "Hall No", "Capacity");
                for (int i = 0; i < CinemaList.Count; i++)
                {
                    c = CinemaList[i];
                    Console.WriteLine("{0,-4}{1,-20}{2,-15}{3,-20}", (i + 1), c.Name, c.HallNo, c.Capacity);
                }
                //Prompts the user for the cinema hall number
                Console.Write("Select a cinema hall: ");
                int hallno = Convert.ToInt32(Console.ReadLine());
                if (hallno > CinemaList.Count || hallno < 0)
                {
                    throw new Exception("\nHall number must be within index");
                }
                Option1(GenreList, MovieList);
                //Prompts the user for the movie number
                Console.Write("Select a movie: ");
                int movieno = Convert.ToInt32(Console.ReadLine());
                if (movieno > MovieList.Count || movieno < 0)
                {
                    throw new Exception("\nMovie number must be within index");
                }
                Console.WriteLine("");
                //Prompts user for a screening type
                Console.Write("Select a screening type [2D/3D]:");
                string screeningtype = Console.ReadLine();
                if (screeningtype != "2D" && screeningtype != "3D")
                {
                    throw new Exception("\nScreening type must either be 2D or 3D");
                }
                //Prompts user for a screening date and time
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
                //Displays if movie screening is successfully created
                Console.WriteLine("Movie Screening successfully created.");
        }
        /**Option 3 method
         * List movie screenings**/
        static void option3(List<string> GenreList, List<Movie> MovieList, List<Screening> ScreeningList)
        {
                Option1(GenreList, MovieList);
                //prompts user for movie number
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
                Console.WriteLine("{0,-13}{1,-10}{2,-25}{3,-17}", "Nil","Nil","Nil","Nil","Nil");
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
                //prompts user for the screening number to be deleted
                Console.Write("Enter a screening number to delete: ");
                int delno = Convert.ToInt32(Console.ReadLine());
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
            {
                Console.WriteLine("Screening number is incorrect");
            }
        }

        /**Option 5 method
         * Order movie ticket**/
        static void option5(List<string> GenreList, List<Movie> MovieList, List<CinemaHall> CinemaHallList, List<Screening> ScreeningList, List<Order> OrderList)
        {
            Screening s = null;
            Option1(GenreList, MovieList);
            //prompts user for a movie number
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
                //prompts user for a session number
                Console.Write("Select a session : ");
                sessionno = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ScreeningList.Count; i++)
                {
                    s = ScreeningList[i];
                    if (s.ScreeningNo == sessionno)
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
            //prompts user for the number of tickets to be purchased
            Console.Write("Please enter number of tickets you wish to purchase: ");
            int tickno = Convert.ToInt32(Console.ReadLine());
            //This condition will run only when the input is more than the cinema hall capacity
            while (tickno > s.CinemaHall.Capacity)
            {
                Console.WriteLine("Ticket number is more than seats remainding, please try again");
                Console.Write("Please enter number of tickets you wish to purchase: ");
                tickno = Convert.ToInt32(Console.ReadLine());
            }
            //Displays the respective output if the movie classification fits the condition
            if (MovieList[movieno - 1].classification == "M18")
            {
                Console.Write("The movie classification is " + MovieList[movieno - 1].classification + ". Does every ticket holder meet the age requirements [Y/N]?");
            }
            else if (MovieList[movieno - 1].classification == "NC16")
            {
                Console.Write("The movie classification is " + MovieList[movieno - 1].classification + ". Does every ticket holder meet the age requirements [Y/N]?");
            }
            else if (MovieList[movieno - 1].classification == "PG13")
            {
                Console.Write("The movie classification is " + MovieList[movieno - 1].classification + ". Does every ticket holder meet the age requirements [Y/N]?");
            }

            string req = Console.ReadLine();
            double total = 0;
            //Create an order list
            Order Ticket = new Order();
            Ticket.status = "Unpaid";
            if (req == "Y" || req == "y" || MovieList[movieno - 1].classification == "G")
            {

                for (int i = 1; i <= tickno; i++)
                {
                    Console.WriteLine("Ticket #" + i);
                    //prompts user to enter student/senior/adult
                    Console.Write("Type of ticket to purchase [Student/Senior/Adult] : ");
                    string ticktype = Console.ReadLine();


                    if (ticktype == "Senior" || ticktype == "senior")
                    {
                        //prompts user to enter year of birth
                        Console.Write("Please enter year of birth [YYYY]: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        if ((DateTime.Now.Year - year) >= 50)
                        {
                            Ticket tick = (new SeniorCitizen(ScreeningList[sessionno - 1001], year));
                            Console.WriteLine("Ticket #" + i + " ordered successfully.");
                            total = total + tick.CalculatePrice();

                        }
                    }
                    else if (ticktype == "Student" || ticktype == "student")
                    {
                        //prompts user to enter primary/secondary/tertiary
                        Console.Write("Please enter level of study [Primary/Secondary/tertiary]: ");
                        string level = Console.ReadLine();
                        Ticket tick = (new Student(ScreeningList[sessionno - 1001], level));
                        Console.WriteLine("Ticket #" + i + " ordered successfully.");
                        total = total + tick.CalculatePrice();
                    }
                    else if (ticktype == "Adult" || ticktype == "adult")
                    {
                        //prompts if the user wants to buy popcorn
                        Console.Write("Do you want to buy popcorn for $3? [Y/N]");
                        string popcorn = Console.ReadLine();
                        if (popcorn == "Y" || popcorn == "y")
                        {
                            
                            Ticket tick = (new Adult(ScreeningList[sessionno - 1001], true));
                            Console.WriteLine("Ticket #" + i + " ordered successfully.");
                            total = total + (tick.CalculatePrice() + 3);
                        }
                        else if (popcorn == "N" || popcorn == "n")
                        {
                            Ticket tick = (new Adult(ScreeningList[sessionno - 1001], false));
                            Console.WriteLine("Ticket #" + i + " ordered successfully.");
                            total = total + tick.CalculatePrice();
                        }
                    }
                    s.SeatsRemaining -= 1;
                }
                Console.WriteLine("Order #" + Order.OrderCount);
                Console.WriteLine("==========");
                Console.WriteLine("Movie title : " + s.Movie.Title);
                Console.WriteLine("Cinema : " + s.CinemaHall.Name);
                Console.WriteLine("Hall : " + s.CinemaHall.HallNo);
                Console.WriteLine("Date/Time : " + s.ScreeningDateTime);
                Console.WriteLine("Total : $" + total);
                Console.WriteLine("==========");
                Console.WriteLine("Press any key to make payment");
                Console.ReadKey();
                Ticket.status = "Paid";
                Console.WriteLine("Thanks you for visiting Singa Cineplexes. Have a great movie!");
            }
        }
        /**Option 6 method
         * Add movie rating**/
        static void option6(List<Movie>MovieList, List<string>GenreList)
        {            
            Option1(GenreList, MovieList);
            //prompts user for the movie number to review the movie
            Console.Write("\nEnter movie number to review the movie: ");
            int movieno = Convert.ToInt32(Console.ReadLine());
            Movie m = MovieList[movieno-1];
            double total = 0;
            for (int i = 0; i < m.Rates.Count; i++)
            {
                total += m.Rates[i];
            }
            double avg = 0;

            if (m.Rates.Count > 0)
            {
                avg = total / m.Rates.Count;
                Console.WriteLine("The current rating for " + m.Title + " is {0:.00}" , avg);
            }
            else
                Console.WriteLine("The current rating for " + m.Title + " is " + avg);
            bool check = false;
            int rate = 0;
            while (check == false)
            {
                //prompts user for the rating
                Console.Write("\nPlease enter a rating [0=Very bad; 5=Very good]: ");
                rate = Convert.ToInt32(Console.ReadLine());
                if (rate >= 0 && rate <= 5)
                {
                    check = true;
                    break;
                }
                else
                    //prompts user to enter a valid value
                    Console.WriteLine("Please enter a valid value between 0 and 5");
            }
            m.Rates.Add(rate);
            //prompts user for the comments about the movie
            Console.Write("Please enter comments about the movie: ");
            string ratingcomment = Console.ReadLine();
            m.Ratingcmts.Add(ratingcomment);
            Console.WriteLine("Thank you for the submission");
            total = 0;
            for (int i = 0; i < m.Rates.Count; i++)
            {
                total += m.Rates[i];
            }
            avg = total / m.Rates.Count;
            Console.WriteLine("The new rating for the movie is {0:.00}", avg);
        }
        /**Option 7 method
         * View movie ratings and comments**/
        static void option7(List<Movie> MovieList, List<string> GenreList)
        {
            Option1(GenreList, MovieList);
            //prompts user for the movie number
            Console.Write("Select a movie: ");
            int movieno = Convert.ToInt32(Console.ReadLine());
            Movie m = MovieList[movieno - 1];
            if (m.Rates.Count > 0)
            {
                double total = 0;
                for (int i = 0; i < m.Rates.Count; i++)
                {
                    total += m.Rates[i];
                }
                double avg = (total / m.Rates.Count);
                Console.WriteLine("\nThe rating for " + m.Title + " is {0:.00}", avg);
                for (int i = 0; i < m.Ratingcmts.Count; i++)                    
                    Console.WriteLine("Comment #" + (i + 1) + " " + m.Ratingcmts[i]);                                    
            }
            else
                Console.WriteLine("\nThere are no ratings or comments for " + m.Title + " yet.");
        }
        /**Option 8 method
         * Recommend a movie(e.g, based on rating, genre, classification, price**/
        static void option8(List<string> GenreList, List<Movie> MovieList, List<string> Ratingcmts, List<double> Rates)
        {
            Option1(GenreList, MovieList);
            Console.Write("Please choose a movie for us to recommend :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How would you like us to recommend based on : ");
            Console.WriteLine("[1] Rating");
            Console.WriteLine("[2] Genre");
            Console.WriteLine("[3] Classification");
            Console.Write("Answer : ");
            int recno = Convert.ToInt32(Console.ReadLine());
            
            double number = 0;
            double highest = 0;
            if (recno == 1)
            {
                for(int i = 0; i < Rates.Count; i++)
                {
                    if(Rates[i] > number)
                    {
                        highest = number;
                       
                    }

                }
                
                Console.WriteLine(highest);
            }
        }        
    }
}
