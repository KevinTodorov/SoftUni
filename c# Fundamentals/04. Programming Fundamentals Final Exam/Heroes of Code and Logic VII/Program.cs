using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] hero = Console.ReadLine().Split();
                string heroName = hero[0];
                int heroHp = int.Parse(hero[1]);
                int heroMp = int.Parse(hero[2]);

                heroes.Add(heroName, new List<int>());
                heroes[heroName].Add(heroHp);
                heroes[heroName].Add(heroMp);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandInArray = command.Split(" - ");
                string action = commandInArray[0];
                string heroName = commandInArray[1];

                switch (action)
                {
                    case "CastSpell":
                    {
                        int mpNeeded = int.Parse(commandInArray[2]);
                        string spellName = commandInArray[3];
                        if (heroes[heroName][1] >= mpNeeded)
                        {
                            heroes[heroName][1] -= mpNeeded;
                            Console.WriteLine(
                                $"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                        }
                        else Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                        break;
                    case "TakeDamage":
                    {
                        int damage = int.Parse(commandInArray[2]);
                        string attacker = commandInArray[3];
                        heroes[heroName][0] -= damage;

                        if (heroes[heroName][0] > 0)
                        {
                            Console.WriteLine(
                                $"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            heroes.Remove(heroName);
                        }
                    }
                        break;
                    case "Recharge":
                    {
                        int amount = int.Parse(commandInArray[2]);

                        if (heroes[heroName][1] + amount <= 200)
                        {
                            Console.WriteLine($"{heroName} recharged for {amount} MP!");
                            heroes[heroName][1] += amount;
                        }
                        else if (heroes[heroName][1] + amount > 200)
                        {
                            int neededMp = 200 - heroes[heroName][1];
                            Console.WriteLine($"{heroName} recharged for {neededMp} MP!");
                            heroes[heroName][1] = 200;
                        }
                    }
                        break;
                    case "Heal":
                    {
                        int amount = int.Parse(commandInArray[2]);

                        if (heroes[heroName][0] + amount <= 100)
                        {
                            Console.WriteLine($"{heroName} healed for {amount} HP!");
                            heroes[heroName][0] += amount;
                        }
                        else if (heroes[heroName][0] + amount > 100)
                        {
                            int neededMp = 100 - heroes[heroName][0];
                            Console.WriteLine($"{heroName} healed for {neededMp} HP!");
                            heroes[heroName][0] = 100;
                        }
                        break;
                    }
                }
                        command = Console.ReadLine();
            }
                foreach (var hero in heroes)
                {
                    Console.WriteLine($"{hero.Key}\r\n  HP: {hero.Value[0]}\r\n  MP: {hero.Value[1]}");
                }
        }
    }
}
