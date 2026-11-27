using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Q1. Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            //double[] prices = {25.5, 40.0, 33.75};
            //Console.WriteLine(prices[1]);
            #endregion

            #region Question 2
            //Q2. Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfCopie =
            //{
            //    {3,5 },
            //    {1,4 }
            //};
            //Console.WriteLine(shelfCopie[1, 0]);
            #endregion

            #region Question 3
            //Q3. Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            PrintWelcomeMessage();
            #endregion
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
    }
}
