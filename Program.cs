using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("Enter a name.");
            string teamMateName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"How skilled is {teamMateName}? 1-10");
            int skillValue = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"How courageous is {teamMateName}? 0.0-2.0");
            double courageRating = double.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine($"{teamMateName}");
            Console.WriteLine($"{skillValue}/10 skill");
            Console.WriteLine($"{courageRating}/2.0 courage");
            }

            
    }
}
