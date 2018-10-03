using System;
using System.Collections.Generic;

namespace notbattleships
{
    class Group
    {
        List<Member> members = new List<Member>();
        
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
            foreach (Member member in members)
            {
                member.Describe();
            }
        }
    }
}