using System;
using System.Diagnostics.Metrics;

namespace movieStore
{
    class myMovieStore
    {
        static void Main(string[] args)
        {

            movie video1 = new movie(1, "The Hobbit", "Peter Jackson");
            video1.SetTrans();
            Console.WriteLine($"ID = {video1.GetId()}, Title = {video1.GetTitle()}, Director = {video1.GetDirector()}");



            movie video2 = new movie();
            video2.SetTrans();
            Console.WriteLine("Please enter the movie's ID number:");
            video2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the movies's Title:");
            video2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the movie's Director:");
            video2.SetAuthor(Console.ReadLine());

            movie video3 = new movie(3, "It", "Andres Muschietti");
            video3.SetTrans();
            
            Console.WriteLine("Please enter the movies's ID:");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the movies's title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the movies's Director: ");
            string tempDirector = Console.ReadLine();

            movie video4 = new movie(tempID, tempTitle, tempDirector);
            video4.SetTrans();

            printTransaction(video4);

            displayVideos(video1);
            displayVideos(video2);
            displayVideos(video3);
            displayVideos(video4);

        }// end of main method 

        static void printTransaction(movie a)
        {
            Console.WriteLine($"The video store has {a.GetTrans()} new movies.");

        }

        static void displayVideos(movie product)
        {
            Console.WriteLine("Here's your movie information");
            Console.WriteLine($"Movie ID: {product.GetId()}");
            Console.WriteLine($"Movie Title: {product.GetTitle()}");
            Console.WriteLine($"Movie Director: {product.GetDirector()}");
        }

    }// end of class

    class movie
    {

        private int _Id;
        private string _Title;
        private string _Director;

        public movie()
        {
            _Id = 0;
            _Title = "";
            _Director = "";

        }// end of default constructor

        public movie(int i, string userTitle, string userDirector)
        {
            _Id = i;
            _Title = userTitle;
            _Director = userDirector;

        }// end of parametric constructor

        public int GetId()
        {

            return _Id;

        }// end of get method - id 

        public string GetTitle()
        {
            return _Title;

        }// end of get method - title 

        public string GetDirector()
        {
            return _Director;

        } // end of get method - Author 

        public void SetId(int identification)
        {
            _Id = identification;
        } // end of set ID

        public void SetTitle(string title)
        {
            _Title = title;
        } // end of set title 

        public void SetAuthor(string director)
        {

            _Director = director;

        }// end of set author

        private static int _transactions = 0;
        private string _accountName;

        public void SetTrans()
        {
            _transactions++;
        }// end of setrans

        public int GetTrans()
        {
            return _transactions;
        }// end of getrans 


    }// end of class movie 

} // end of namespace

