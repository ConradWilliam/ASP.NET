using System;

namespace FavoriteNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for favorite number
            Console.Write("Enter your favorite number: ");
            
            // Read the user's input and convert it to an int
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            // Output the user's favorite number
            Console.WriteLine("Your favorite number is: " + favoriteNumber);

            // Add more code here to perform other operations with favoriteNumber if needed

            // Wait for user input to close the console window
            Console.ReadLine();
        }
    }
}
