using System;

namespace notbattleships
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("What is your name?");
            string stupidName = Console.ReadLine();
            Console.WriteLine($"Piss off {stupidName}");
            Console.WriteLine($"How old are you, {stupidName}?");
            int soOld = int.Parse(Console.ReadLine());
            Console.WriteLine("How are you still breathing?");
            float lifeExpectancy = (68.3f - soOld) * 52.1429f;
            if (lifeExpectancy > 0)  
            {                           
                Console.WriteLine($"You've only got {lifeExpectancy} weeks left!");
            }
            else
            {
                Console.WriteLine($"You're already dead! You died {- lifeExpectancy} weeks ago!");
            }
            Console.ReadKey();
        }
    }
}