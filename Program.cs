using System;

namespace notbattleships
{
    class Program
    {
        static void Main(string[] args)
        {
            RandoMemberGenerator.Load("nouns.txt", "31K_verbs.txt", "adjectives.txt","names.txt");

            // Name the group
            Console.WriteLine("What the name of the group?");
            Group AA = new Group(Console.ReadLine());

            // Add default members
            AA.AddMember(new Member("Harold", 65, "attack helicopter", "win the gulf war"));
            AA.AddMember(new Member("Kyo", 22, "catfish", "succeed"));
            AA.AddMember(new Member("Harold2", 90, "goldfish", "be named Harold"));
            AA.AddMember(RandoMemberGenerator.Reroll());
            AA.AddMember(RandoMemberGenerator.Reroll());
            AA.AddMember(RandoMemberGenerator.Reroll());
            AA.AddMember(RandoMemberGenerator.Reroll());
            AA.AddMember(RandoMemberGenerator.Reroll());
           
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Add a member");
            Console.WriteLine("2) Report a death");
            Console.WriteLine("3) List members");
            Console.WriteLine("4) Make shit up");
            Console.WriteLine("5) Russian roulette");

            Console.ReadKey();

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