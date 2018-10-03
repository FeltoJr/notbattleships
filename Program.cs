using System;

namespace notbattleships
{
    class Program
    {
        static void Main(string[] args)
        {
            Group AA = new Group("AA branch 14");
            AA.AddMember(new Member("Harold", 65, "attack helicopter", "win the gulf war"));
            AA.AddMember(new Member("Kyo", 22, "catfish", "succeed"));
            AA.AddMember(new Member("Harold2", 90, "goldfish", "be named Harold"));
            AA.DescribeMembers();


            Console.ReadKey();
        }
        static void OtherMethod()
        {
            
            Console.WriteLine("What is your name?");
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

            Console.WriteLine("What are you?");
            string politicallyCorrectGender = Console.ReadLine();
            Console.WriteLine($"What are your hopes and dreams? Dicktwat. Sorry I mean {stupidName}");
            string hopesAndDreams = Console.ReadLine();

            Member aPerson = new Member(stupidName, soOld, politicallyCorrectGender, hopesAndDreams);
            aPerson.Describe();
        }
    }
}