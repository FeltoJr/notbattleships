using System;
using System.Collections.Generic;

namespace notbattleships
{
    class Group
    {
        List<Member> members = new List<Member>();
        string name;
        public Group(string name)
        {
            this.name = name;
        }
        
        public void AddMember(Member member)
        {
            members.Add(member);
        }
        
        public void ListMembers()
        {
            foreach (Member member in members)
            {
                Console.WriteLine(member.name);
            }            
        }
        public void DescribeMembers()
        {
            Console.WriteLine($"These are the things in {name}:");
            foreach (Member member in members)
            {
                member.Describe();
            }
        }
    }
}