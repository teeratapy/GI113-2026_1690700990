/*
* Student ID :1690700990
* Name       :teeratap yotee
* Section    :129A
* No.        :34
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Battle Setup
            const int MonsterHp = 10;
            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");

            // Step 2 & Part B: Battle Menu & Switch Statement
            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Lightning Strike"); // 1/3 Part B: เพิ่มเมนู 5
            Console.Write("Choose (1-5): "); // เปลี่ยน prompt เป็น 1-5
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                case 5:
                    Console.WriteLine("Hero calls down Lightning!"); // 2/3 Part B: case 5
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }

            // Step 3 & Part B: Power using Switch Expression
            int power = command switch
            {
                1 => 12,
                2 => 18,
                5 => 25, // 3/3 Part B: ตั้งค่าพลังคำสั่งที่ 5 (เช่น 25)
                _ => 0
            };

            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            // Step 4: Rating using Relational Patterns
            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            // Step 5: Monster Status using Ternary Operator
            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            // Step 6: Escape Confirmation with Multiple Cases
            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
        }
    }
}