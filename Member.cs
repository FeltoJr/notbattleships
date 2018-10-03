using System;

namespace notbattleships
{
    class Member
    {
        public string name {private set; get;}
        int age;
        string gender;
        string hopesAndDreams;
        
        public Member(string name, int age, string gender, string hopesAndDreams)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.hopesAndDreams = hopesAndDreams;
        }
        public void Describe()
        {
            Console.WriteLine($"Hi, I'm {name} the {gender}. I spent {age} years trying to {hopesAndDreams}. I failed.");
        }
    }
}