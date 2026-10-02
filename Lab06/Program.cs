/*
* Student ID :1690700990
* Name       :teeratap_yote
* Section    :129A
* No.        :34
* Course     : GI113 Computer Programming (GI)
*/
using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Dragon Slayer: The Decision ===");
            Console.WriteLine("A wild dragon appears in front of you!");
            Console.WriteLine("ACTION A: Swing your Greatsword");
            Console.WriteLine("ACTION B: Cast a Fireball");
            Console.WriteLine("ACTION C: Drink a Healing Potion");
            Console.Write("\nChoose your action (A, B, or C): ");

            string input = Console.ReadLine();
            bool isParsed = char.TryParse(input, out char choice);

            // Convert character to uppercase to support both lowercase and uppercase input
            choice = char.ToUpper(choice);

            if (!isParsed)
            {
                Console.WriteLine("Invalid input! Please enter a single character.");
            }
            else if (choice == 'A')
            {
                Console.WriteLine("You slash the dragon with your sword and deal 45 damage!");
            }
            else if (choice == 'B')
            {
                Console.WriteLine("You launch a powerful fireball! The dragon takes 60 magic damage.");
            }
            else if (choice == 'C')
            {
                Console.WriteLine("You drink a health potion and restore 35 HP.");
            }
            else
            {
                Console.WriteLine("Invalid action! Please choose only A, B, or C.");
            }
        }
    }
}