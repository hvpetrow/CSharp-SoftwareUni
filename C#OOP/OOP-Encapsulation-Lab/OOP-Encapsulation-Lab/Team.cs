using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        private IReadOnlyCollection<Person> firstTeam1;

        public Team(string name)
        {
            this.name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam { get { return firstTeam.AsReadOnly(); } private set => firstTeam1 = value; }
        public IReadOnlyCollection<Person> ReserveTeam { get { return reserveTeam.AsReadOnly(); } private set => firstTeam1 = value; }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);

            }
            else
            {
                reserveTeam.Add(person);
            }
        }

    }
}
