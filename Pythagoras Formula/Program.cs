using System;

namespace PythagoraSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double Hypotenus = 0, opposite = 0, Adjacent = 0;
                double Result = 0;
                 

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("         Pythagoras Theorem Calculaor");
                Console.WriteLine("---------------------------------------------");

                Console.WriteLine("Options: ");
                Console.WriteLine("1. Calculate  Hypotenus: ");
                Console.WriteLine("2. Calculate  Opposite:  ");
                Console.WriteLine("3. Calculate  Adjacent:  ");

                Console.WriteLine("Choose an option (1   or    2    or    3): ");  

                switch (Console.ReadLine())
                { 
                    case "1":
                            Console.WriteLine("Enter the legth of the opposite: ");
                            while(!double.TryParse(Console.ReadLine(), out opposite))
                            {
                            Console.WriteLine("Invalid Input.....Please input an integer");
                            Console.Write("Enter the length of the opposite: ");
                            }
                            Console.WriteLine("Enter the value of Adjacent: ");
                            while (!double.TryParse(Console.ReadLine(), out Adjacent))
                            { 
                            Console.WriteLine("Invalid Input.....Please input an integer");
                            Console.Write("Enter the length of the Adjacent: ");
                            }
                            Result = Math.Sqrt((Adjacent * Adjacent) + (opposite * opposite));
                            Console.WriteLine($"Tne Hypotenus is: = {Result}");                  
                        break;
                    case "2":
                            Console.WriteLine("Enter the legth of the Hypotenus: ");
                            while (!double.TryParse(Console.ReadLine(), out Hypotenus))
                            {
                            Console.WriteLine("Invalid Input.....Please input an integer");
                            Console.Write("Enter the length of the Hypotenus: ");
                            }
                            Console.WriteLine("Enter the legth of the Adjacent: ");
                            while (!double.TryParse(Console.ReadLine(), out Adjacent)) 
                            {
                            Console.WriteLine("Invalid Input.....Please input an integer");
                            Console.Write("Enter the length of the Adjacent: ");
                            }
                            Result = Math.Sqrt((Hypotenus * Hypotenus) - (Adjacent * Adjacent));
                            Console.WriteLine($"Tne Opposite is: = {Result}");
                        break;  
                    case "3":
                            Console.WriteLine("Enter the legth of the Hypotenus: ");
                            while (!double.TryParse(Console.ReadLine(), out Hypotenus))
                            {
                            Console.WriteLine("Invalid Input.....Please input an integer");
                            Console.Write("Enter the length of the Hypotenus: ");
                            }
                            Console.WriteLine("Enter the legth of the opposite: ");
                            while (!double.TryParse(Console.ReadLine(), out opposite)) 
                            {
                            Console.WriteLine("Invalid Input.....Please input an integer");
                            Console.Write("Enter the length of the opposite: ");
                            }

                            Result = Math.Sqrt((Adjacent * Adjacent) - (opposite * opposite));
                            Console.WriteLine($"The Adjacent is: = {Result}");
                        break;
                    default:
                        Console.WriteLine("Invalid Input!!!");
                        break;
                }
                Console.Beep();
                Console.WriteLine("To Restart the program click \"Y\" ");
                Console.Write("Press any button to end the program");
            }
            while (Console.ReadLine()?.ToUpper() == "Y");
            {
                Console.WriteLine("Have a Good Day!!!");
            }
        }
    }
}
