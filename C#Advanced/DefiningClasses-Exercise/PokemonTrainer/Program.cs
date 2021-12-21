using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string ,Trainer> trainersDictionary = new Dictionary<string,Trainer>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Tournament")
                {
                    break;
                }

                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);

                if (!trainersDictionary.ContainsKey(trainerName))
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    trainersDictionary.Add(trainerName, newTrainer);
                }
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = trainersDictionary[trainerName];
                trainer.Pokemons.Add(pokemon); 
            }

            while (true)
            {
                string element = Console.ReadLine();

                if (element == "End")
                {
                    break;
                }

                foreach (var trainer in trainersDictionary)
                {
                    if (trainer.Value.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Value.NumberOfBadges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            foreach (var item in  trainersDictionary.OrderByDescending(x=>x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{item.Key} {item.Value.NumberOfBadges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
