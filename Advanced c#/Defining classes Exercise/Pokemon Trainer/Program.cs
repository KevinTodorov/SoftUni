using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Trainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var trainers = new List<Trainers>();

            while (input != "Tournament")
            {
                string[] inputInArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = inputInArr[0];
                string pokemonName = inputInArr[1];
                string pokemonElement = inputInArr[2];
                int pokemonHealth = int.Parse(inputInArr[3]);
                var pokemons = new Pokemon(name, pokemonElement, pokemonHealth);
                if (!trainers.Any(x => x.Name == name))
                {
                    trainers.Add(new Trainers(name));
                }

                var currTrainer = trainers.Find(n => n.Name == name);

                currTrainer.Pokemons.Add(pokemons);

                input = Console.ReadLine();
            }

            string element = Console.ReadLine();
            while (element != "End")
            {
                foreach (Trainers trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }

                element = Console.ReadLine();
            }

            foreach (Trainers trainer in trainers.OrderByDescending(b => b.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
        
    }
}
