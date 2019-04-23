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


            /*Calculate the perimeter and area of classrooms 
            (Hint use length and width)*/

            Double L, W, H;
            Double perimeter, area, volume;
            String response = "yes";

            /*Use While loop to enable repetitive use of calculator
            with escape being 'n' and continue 'y'*/

            while (response == "yes")
            {
                Console.Write("Please Enter the length of the classroom: ");
                L = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please Enter the width of the classroom: ");
                W = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please Enter the height of the classroom: ");
                H = Double.Parse(Console.ReadLine());
                Console.WriteLine();

                perimeter = 2 * L + 2 * W;

                area = L * W;

                volume = L * W * H;

                Console.Write("Your calculated Perimeter: " + perimeter + " ft\n");

                Console.Write("Your calculated Area: " + area + " square ft\n");

                Console.Write("Your calculated Volume: " + volume + " ft cubed\n");

                Console.WriteLine("Would you like to continue? [type yes or no] \n");
                response = Console.ReadLine();
            }
        }
    }
}
