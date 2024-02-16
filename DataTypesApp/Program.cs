using System;
namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the pieces of pieces of apple: ");
            int applePieces = int.Parse(Console.ReadLine());

            Console.Write($"Enter the total of prices of {applePieces} apple(s): ");
            double priceTotal = double.Parse(Console.ReadLine());

            Console.WriteLine($"The total price of {applePieces} apples(s) is {priceTotal}");
            int convertedPrice = (int)priceTotal;

            Console.WriteLine($"The value of original price is {priceTotal}");
            Console.WriteLine($"The value of converted price is {convertedPrice}");

            Console.WriteLine("Press any key to exit.....");
            Console.ReadKey();

        }
    }
}
