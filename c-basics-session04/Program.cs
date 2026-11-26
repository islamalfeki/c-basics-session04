using System.Drawing;
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

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);

            // I expect it will print 400 because that's passing by value - value type so the function takes a copy
            // from pages in a stack frame and it will be removed from stack after function finish .

            #endregion

            #region Question06
            // Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it 
            // with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);

            // I expect it will print 20.5 because that's passing by value - reference type so both array and method
            // refers to the same address in heap

            #endregion

            #region Question07
            // Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. 
            // Call it and print pages afterward. How is the result different from question 5 ?

            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);  // 450

            // Because that's passing by ref - value type so the method change the original value not a copy .

            #endregion

            #region Question08
            // Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a 
            // new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.

            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);   // 3   passing by reference - reference type



            #endregion

            #region Question09
            // Write a method bool TryGetPrice(string title, out double price) that returns true and sets 
            // price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            // and print the price if found

            string title = "Clean Code";
            double price;                  // out parameter does not need to be initialized before calling 

            TryGetPrice(title , out price);

            Console.WriteLine(price);


            #endregion
        }

        // Question03
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        // Question04
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book Title: " + title);
        }

        // Question05
        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        // Question06 
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        // Question07
        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        // Question08
        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        // Question09
        public static bool TryGetPrice(string title, out double price)
        {
           if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
                
        }


    }
}
