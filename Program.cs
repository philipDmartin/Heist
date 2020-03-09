using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> Team = new List<Dictionary<string, string>>();
            int bankDifLevel = 100;

            Console.WriteLine("plan your heist");

            while (true)
            {
                Dictionary<string, string> TeamMember = new Dictionary<string, string>();

                Console.WriteLine("please enter a name");
                string memberName = Console.ReadLine();

                if (memberName == "")
                {
                    break;
                }

                TeamMember.Add("Name", memberName);

                Console.WriteLine("please enter a skill level between 1-10");
                string memberSkill = Console.ReadLine();
                int memberSkillInt = int.Parse(memberSkill);
                TeamMember.Add("Skill", memberSkill);

                Console.WriteLine("please enter a courage level between 0.0-2.0");
                string memberCourage = Console.ReadLine();
                TeamMember.Add("Courage", memberCourage);

                Team.Add(TeamMember);

                foreach (Dictionary<string, string> member in Team)
                {
                    foreach (KeyValuePair<string, string> memberData in member)

                    {
                        Console.WriteLine($"{memberData.Key}: {memberData.Value}");
                    }
                }
            }

            int teamSkillLevel = 0;

            foreach (Dictionary<string, string> member in Team)
            {
                int memberSkillLevel = int.Parse(member["memberSkill"]);
                teamSkillLevel += memberSkillLevel;
            }

            Console.WriteLine($"{ teamSkillLevel }");

            Console.WriteLine(bankDifLevel);

            Console.WriteLine("------------");


            foreach (Dictionary<string, string> member in Team)
            {
                foreach (KeyValuePair<string, string> memberData in member)

                {
                    Console.WriteLine($"{memberData.Key}: {memberData.Value}");
                }
            }
        }
    }
}
