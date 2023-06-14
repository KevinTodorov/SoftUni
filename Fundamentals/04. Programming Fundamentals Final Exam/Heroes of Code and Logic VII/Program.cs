using System;
using System.Collections.Generic;

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
                string[] newHero = Console.ReadLine().Split();
                string heroName = newHero[0];
                int hp = int.Parse(newHero[1]);
                int mp = int.Parse(newHero[2]);
                if (hp >= 0 && hp <= 100 && mp >= 0 && mp <= 200)
                {
                    heroes.Add(heroName, new List<int>());
                    heroes[heroName].Add(hp);
                    heroes[heroName].Add(mp);
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(" - ");
                string action = command[0];
                string heroName = command[1];

                switch (action)
                {
                    case "CastSpell":
                    {
                        int mpNeeded = int.Parse(command[2]);
                        string spellName = command[3];

                        if (heroes[heroName][1] >= mpNeeded)
                        {
                            heroes[heroName][1] -= mpNeeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                        }else Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    } 
                        break;
                    case "TakeDamage":
                    {
                        int damage = int.Parse(command[2]);
                        string attacker = command[3];
                        heroes[heroName][0] -= damage;

                        if (heroes[heroName][0] > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
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
                        int amount = int.Parse(command[2]);

                        if (heroes[heroName][1] + amount > 200)
                        {
                            Console.WriteLine($"{heroName} recharged for {200 - heroes[heroName][1]} MP!");
                            heroes[heroName][1] = 200;
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} recharged for {amount} MP!");
                            heroes[heroName][1] += amount;
                        }
                    }
                        break;
                    case "Heal":
                    {
                        int amount = int.Parse(command[2]);

                        if (heroes[heroName][0] + amount > 100)
                        {
                            Console.WriteLine($"{heroName} healed for {100 - heroes[heroName][0]} HP!");
                            heroes[heroName][0] = 100;
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} healed for {amount} HP!");
                            heroes[heroName][0] += amount;
                        }
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}\r\n  HP: {hero.Value[0]}\r\n  MP: {hero.Value[1]}");
            }

        }
    }
}
