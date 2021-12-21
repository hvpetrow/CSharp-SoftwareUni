using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                try
                {
                 string teamName = tokens[1];

                    if (command=="Team")
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (command=="Add")
                    {
                        if (!teams.Any(t=> t.Name == teamName))
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            Team currentTeam = teams.First(t => t.Name == teamName);
                            currentTeam.AddPlayer(new Player(tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7])));

                        }                       
                    }
                    else if (command == "Remove")
                    {
                        Team teamToRemove = teams.First(t => t.Name == teamName);
                        teamToRemove.RemovePlayer(tokens[2]);

                    }
                    else if (command == "Rating")
                    {
                        if (!teams.Any(t=> t.Name == teamName))
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            Console.WriteLine(teams.First(t=>t.Name == teamName).ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
