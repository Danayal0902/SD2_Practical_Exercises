using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaHouse
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declare variables
            double length = 0;
            double width = 0;
            double areaCurrent = 0;
            double totalArea = 0;
            int rooms = 0;
            int counter = 0;

            //Ask the user how many rooms there are in the house
            Console.WriteLine("How many rooms are there?");
            rooms = int.Parse(Console.ReadLine());

            //Ask measurements of each room
            do
            {
                Console.WriteLine("Please enter room length in metres");
                length = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter room width in metres");
                width = Double.Parse(Console.ReadLine());

                //Add the current rooms length and width and display it
                areaCurrent = length * width;
                Console.WriteLine("This room is " + areaCurrent + " square metres.");
                Console.ReadLine();

                //Increment the loop
                ++counter;
                totalArea = totalArea + areaCurrent;
               
            } 

            //Keep the loop going until the value of the rooms is less than 0
            while (counter < rooms);

            //Display the total area of the house by adding all the values of each room
            Console.WriteLine("The total area is " + totalArea + " square metres.");
            Console.ReadLine();
        }
    }
}
