/*
* Student ID :1690700990
* Name       :teeratap_yote
* Section    :129A
* No.        :34
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants (PascalCase)
            const string MaterialName = "Iron";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            // Display Header
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to the Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
            Console.WriteLine($"=> Key 'S' for Smelt ({MaterialName} Ore -> {MaterialName} Ingot)");
            Console.WriteLine($"=> Key 'B' for Breakdown ({MaterialName} Ingot -> {MaterialName} Ore)");

            // Get Menu Input
            Console.Write("=> Choose Menu: ");
            string rawMenuInput = Console.ReadLine();
            bool isMenuValid = char.TryParse(rawMenuInput, out char menu);

            // Get Amount Input
            Console.Write("=> How much would you like: ");
            string rawAmountInput = Console.ReadLine();
            bool isAmountValid = double.TryParse(rawAmountInput, out double amount);

            // Logic Validation and Processing
            if (isAmountValid && amount > 0 && amount <= MaxBatch)
            {
                // Nested if inside amount validation
                if (menu == 'S' || menu == 's')
                {
                    double result = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double result = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {result:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu selection.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid amount. Must be a number greater than 0 and not exceeding MaxBatch.");
            }
        }
    }
}