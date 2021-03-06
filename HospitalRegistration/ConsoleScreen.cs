using System;
using System.Collections.Generic;

namespace HospitalRegistration
{
    public static class ConsoleScreen
    {
        public static List<string> Departments { get;  }

        static ConsoleScreen()
        {
            Departments = new List<string>();
            Departments.Add("Pediatrics");
            Departments.Add("Stamatology");
            Departments.Add("Traumatology");
        }

        public static int Input(int length)
        {
            while (true)
            {
                Console.Write(">> ");

                var status = int.TryParse(Console.ReadLine(), out int choice);

                if (status)
                {
                    if (choice > 0 && choice <= length)
                        return choice;

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Input must be between [ 1 - {length} ]!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please enter numeric value!");
                }
                Console.ResetColor();
            }
        }

        public static void PrintMenu(List<string> options)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
            Console.ResetColor();
        }

        public static void Clear()
        {
            Console.WriteLine("Press enter to continue!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}