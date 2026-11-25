using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_basics_session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print 
            //the second price(index 1)

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region Question02
            // Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and 
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0

            //int[,] shelfCopies =
            //{
            //    { 3, 5 },
            //    { 1, 4 }
            //};

            //Console.WriteLine(shelfCopies[1,0]);


            #endregion

            #region Question03
            // Write a method called PrintWelcomeMessage that takes no parameters and prints 
            //"Welcome to the Library!".Call it from Main./

            //PrintWelcomeMessage();

            #endregion

            #region Question04
            // Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with 
            //"Clean Code".

            //PrintBookTitle("Clean Code");
            #endregion

            #region Question05
            // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable 
            //int pages = 400; and print pages afterward. What do you expect to see, and why? 

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);

            // I expect it will print 400 because that's passing by value - value type so the function takes a copy
            // from pages in a stack frame and it will be removed from stack after function finish .

            #endregion
        }

        // Question03
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        // Question04
        public static void PrintBookTitle (string title)
        {
            Console.WriteLine("Book Title: " + title);
        }

        // Question05
        public static void AddBonusPages (int pages)
        {
            pages += 50 ;
        }
    }
}
