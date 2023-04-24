using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }

        public List<string> Members;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string creator = input[0];
                string teamToJoin = input[1];

                if (teams.Any(team => team.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} was already created!");
                }else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    team.TeamName = teamToJoin;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamToJoin} has been created by {creator}!");
                }
            }

            string line = Console.ReadLine();

            while (true)
            {
                if (line == "end of assigment")
                {
                    break;;
                }

                string[] lineInArray = line.Split("->");
                string member = lineInArray[0];
                string teamToJoIn = lineInArray[1];

                if (!teams.Any(team => team.TeamName.Contains(teamToJoIn)))
                {
                    Console.WriteLine($"Team {teamToJoIn} does not exist!");
                }else if ((teams.Any(team => team.Members.Contains(member))) || 
                          teams.Any(team => team.Creator == member))
                {
                    Console.WriteLine($"Memeber {member} cannot join team {teamToJoIn}");
                }
                else
                {
                    var currTeam = teams.First(team => team.TeamName == teamToJoIn);
                    currTeam.Members.Add(member);
                }
                line = Console.ReadLine();
            }

            var finalTeams = teams.Where(team => team.Members.Count > 0);
            var disbandedTeams = teams.Where(team => team.Members.Count == 0);
            foreach (Team teamsTeam in teams.OrderByDescending(team => team.Members.Count).
                         ThenBy(team => team.TeamName))
            {
                Console.WriteLine(teamsTeam.TeamName);
                Console.WriteLine($"- {teamsTeam.Creator}");
                foreach (string member in teamsTeam.Members.OrderBy(member => member))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (disbandedTeams != null)
            {
                foreach (Team disbandedTeam in disbandedTeams.OrderBy(team => team))
                {
                    Console.WriteLine($"{disbandedTeam.TeamName}");
                }
            }
        }
    }
}
