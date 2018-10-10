using System;

namespace notbattleships
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doThing = true;

            
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
           
            while (doThing) 
            {

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Add a member");
            Console.WriteLine("2) Report a death");
            Console.WriteLine("3) List members");
            Console.WriteLine("4) Make shit up");
            Console.WriteLine("5) Russian roulette");

            int option = int.Parse(Console.ReadLine());
            switch (option) 
                {
                case 1:
                    AA.AddMember(OptionOne());
                    break;
                case 2:
                    Console.WriteLine("I am option 2. I don't work yet!");
                    break;
                case 3:
                    AA.DescribeMembers();
                    break;
                case 4:
                    AA.AddMember(RandoMemberGenerator.Reroll());
                    Console.WriteLine("Someone got added!");
                    break;
                case 5:
                    Console.WriteLine("Bang bang!");
                    break;
                    
                default:
                    Console.WriteLine("I am not an option :(");
                    break;
                }
           

                Console.WriteLine("Say 'exit' to exit");
                string input = Console.ReadLine();
                if (input == "exit") 
                {
                    Console.WriteLine("Bye!");
                    doThing = false;
                }

            }
        }
        static Member OptionOne()
        {
                    Console.WriteLine("What is their name?");
                    string stupidName = Console.ReadLine();
                    Console.WriteLine($"How old is {stupidName}?");
                    int soOld = int.Parse(Console.ReadLine());
                    Console.WriteLine("How are they still breathing?");
                    float lifeExpectancy = (68.3f - soOld) * 52.1429f;
                    if (lifeExpectancy > 0)  
                    {                           
                        Console.WriteLine($"They've only got {lifeExpectancy} weeks left!");
                    }
                    else
                    {
                        Console.WriteLine($"They're already dead! They died {- lifeExpectancy} weeks ago!");
                    }

                    Console.WriteLine("What are they?");
                    string politicallyCorrectGender = Console.ReadLine();
                    Console.WriteLine($"What are {stupidName}'s hopes and dreams?");
                    string hopesAndDreams = Console.ReadLine();
                    return new Member(stupidName, soOld, politicallyCorrectGender, hopesAndDreams);

        }
    }
}