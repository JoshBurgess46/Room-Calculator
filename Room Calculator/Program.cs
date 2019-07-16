using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input--2 numbers
            Console.WriteLine("Welcome to the Room Calculator! Please hit enter to continue.");
            Console.ReadLine();
        here:
            //processing--calculate area and perimeter
            Console.WriteLine("Please enter the length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height:");
            double height = double.Parse(Console.ReadLine());

            //displays area and perimeter
            double vol = length * width * height;
            Console.WriteLine("The volume of the room is " + vol);
            Console.ReadLine();

            double area = length * width;
            Console.WriteLine("The area of the room is " + area);
            Console.ReadLine();

            double perimeter = 2 * (width + length);
            Console.WriteLine("The perimeter of the room is " + perimeter);
            Console.ReadLine();
        there:
            Console.WriteLine("Would you like to try again? (Y or N) ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "y":
                case "Y":
                    goto here;
                case "n":
                case "N":
                    break;
                default:
                    Console.WriteLine("Sorry I don't understand.");
                    goto there;

            }
            Console.WriteLine("Good-Bye!");
            Console.ReadLine();




            //displays area and perimeter
        }
    }
}