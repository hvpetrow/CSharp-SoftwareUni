using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Mission;

namespace SpaceStation.Core
{
    
    public class Controller : IController
    {
        private int exploredPlantes;
        private readonly AstronautRepository<IAstronaut> spaceStation;
        private readonly AstronautRepository<IPlanet> planets;

        public Controller()
        {
            spaceStation = new AstronautRepository();
            planets = new PlanetRepository();
        }
        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);

            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException("Astronaut type doesn't exists!");
            }

            spaceStation.Add(astronaut);
            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }

            planets.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            IMission mission = new Mission();
            var planet = planets.FindByName(planetName);
            var suitableAstronauts = spaceStation.Models.Where(a => a.Oxygen > 60).ToList();

            if (suitableAstronauts.Count() == 0)
            {
                throw new InvalidOperationException("You need at least one astronaut to explore the planet");
            }

            mission.Explore(planet, suitableAstronauts);

            int deadAstronauts = suitableAstronauts.Where(a => a.Oxygen <= 0).Count();
            exploredPlantes++;
            return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts} dead astronauts!";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exploredPlantes} planets were explored!");
            sb.AppendLine("Astronauts info:");

            foreach (var astronaut in spaceStation.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");
                if (astronaut.Bag.Items.Count == 0)
                {
                    sb.AppendLine("Bag items: none");
                }
                else
                {
                   
                    sb.AppendLine($"Bag items: {String.Join(", ", astronaut.Bag.Items)}");
                }
            }

                return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            var retiredAstronaut = spaceStation.FindByName(astronautName);

            if (retiredAstronaut == null)
            {
                throw new InvalidOperationException("Astronaut {astronautName} doesn't exists!");
            }

            spaceStation.Remove(retiredAstronaut);
            return $"Astronaut {astronautName} was retired!";
        }
    }
}
