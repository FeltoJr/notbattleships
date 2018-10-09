using System;
using System.Collections.Generic;
using System.IO;

namespace notbattleships
{
    static class RandoMemberGenerator
    {
        static string[] nouns;
        static string[] verbs;
        static string[] adjs;
        static string[] names;
        static Random rando = new Random();

        public static void Load(string nounPath, string verbPath, string adjPath, string namePath)
        {
            nouns = File.ReadAllLines(nounPath);
            verbs = File.ReadAllLines(verbPath);
            adjs = File.ReadAllLines(adjPath);
            names = File.ReadAllLines(namePath);
        }

        public static Member Reroll()
        {
            int nounRmg = rando.Next(nouns.Length);
            int verbRmg = rando.Next(verbs.Length);
            int adjRmg = rando.Next(adjs.Length);
            int nameRmg = rando.Next(names.Length);

            bool isAdj = rando.Next(0,1) == 1;

            string prefix = isAdj ? adjs[adjRmg] : verbs[verbRmg];

            return new Member(names[nameRmg], rando.Next(1, 134), $"{prefix} {nouns[nounRmg]}", verbs[rando.Next(verbs.Length)]);
          //  "The Abjective Verb Noun"
        }
    }
}