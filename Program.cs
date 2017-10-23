using System;
using System.Collections.Generic;

namespace Random_Number
{
    class Program
    {
        static List<string> Falconers = new List<string> { "Debbie","Heidi","Noel","Melissa","Kirsten","Koshy" };
        static List<string> Falcons = new List<string> { "Hisan","Ka Kite","Siren","Koa","Stella","Mojo" };
        static void Main(string[] args)
        {
                 //Start the program with Clear();
            Console.Clear();

            Console.WriteLine(DisplayFalcons());
            Console.WriteLine(DisplayFalcons());
            Console.WriteLine(DisplayFalcons());

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
             static int GenerateRandomNumber(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, myList.Count);
        }

        static string DisplayFalcons()
        {

            var selectedFalconers = Falconers[GenerateRandomNumber(Falconers)];
            var selectedFalcons = Falcons[GenerateRandomNumber(Falcons)];

            
            return $"Selected Falcons = {selectedFalcons}\nSelected Falconers = {selectedFalconers}";
        }
    } 
}