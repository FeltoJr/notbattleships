using System;
using System.Collections.Generic;

namespace notbattleships
{
    class Group
    {
        List<Member> members = new List<Member>();
        public string Name { get; private set; }
        public Group(string name)
        {
            this.Name = name;
        }
        
        public void AddMember(Member member)
        {
            members.Add(member);
        }
        
        public void ListMembers()
        {
            for (int i = 0; i < members.Count; i++) {
                Console.WriteLine($"{i}: {members[i].name}");
            }
        }
        public void DescribeMembers()
        {
            Console.WriteLine($"These are the things in {Name}:");
            foreach (Member member in members)
            {
                member.Describe();
            }
        }
        public Member RussianRoulette()
        {
            Random gun = new Random();
            int boolett = gun.Next(members.Count);
            Member victim = members[boolett];
            members.RemoveAt(boolett);
            return victim;
        }
        
        public Member RemoveMember(int ded)
        {
            Member victim = members[ded];
            members.RemoveAt(ded);
            return victim;
        }
    }
}