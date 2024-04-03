using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double boomersAge = 8.5;
            double acesAge = 6.5;
            int boomersAgeInt = Convert.ToInt32(boomersAge);
            int acesAgeInt = Convert.ToInt32(acesAge);
            string boomersName = "Boomer";
            string acesName = "Ace";
            bool oldestDog = true;
            bool youngestDog = false;
            string acesSymbol = "@";
            char acesSymbolChar = Convert.ToChar(acesSymbol);

            Console.Write("We have two dogs named ");
            Console.Write(boomersName + " and " + acesName + "\n");
            Console.ReadKey();
            Console.WriteLine(boomersName + " is " + boomersAgeInt + " years oldd\b!");
            Console.ReadKey();
            Console.Write(acesName + " is " + acesAgeInt + " years old!\n");
            Console.ReadKey();
            Console.WriteLine(boomersName + " is the oldest dog\t " + oldestDog);
            Console.ReadKey();
            Console.WriteLine(acesName + " is the oldest dog\t " + youngestDog);
            Console.ReadKey();
            Console.WriteLine(boomersName + " and " + acesName + " live " + acesSymbolChar + " 34 Some Place");
            Console.ReadKey();
            Console.Beep();

        }
    }
}
