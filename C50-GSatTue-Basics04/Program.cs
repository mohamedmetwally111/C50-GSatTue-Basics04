using System.Runtime.Intrinsics.X86;
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
            //PrintWelcomeMessage();
            #endregion

            #region Question 4
            //Q4. Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            //PrintBookTitle("Clean Code");
            #endregion

            #region Question 5
            //Q5. Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why? 
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            #endregion

            #region Question 6
            //Q6.Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why? 
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);
            #endregion
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }

        static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
    }
}
