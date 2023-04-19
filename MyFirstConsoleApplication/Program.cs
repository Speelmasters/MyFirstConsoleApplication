using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Christian Speelman";
            string location = "Coeur d'Alene";


            Console.WriteLine($"My name is : {name}");
            Console.WriteLine($"I am from: {location}");

            DateTime dateTime = DateTime.Now;
            string dateValue = dateTime.ToString("MM/dd/yyyy");
            Console.WriteLine($"The current date is: {dateValue}");

            DateTime today = DateTime.Today;
            DateTime Christmas = new DateTime(today.Year, 12, 25);

            if (Christmas < today)
                Christmas = Christmas.AddYears(1);
            int numDays = (Christmas - today).Days;
            Console.WriteLine($"The number of days until Christmas: {numDays}");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("What is the width of the board: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("What is the height of the board: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");


            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
