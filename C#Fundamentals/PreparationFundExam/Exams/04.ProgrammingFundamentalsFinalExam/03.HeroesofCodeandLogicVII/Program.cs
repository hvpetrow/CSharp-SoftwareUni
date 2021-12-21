using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> hpByName = new Dictionary<string, int>();
            Dictionary<string, int> manaPointsByName = new Dictionary<string, int>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" " ,  StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                if (!hpByName.ContainsKey(name))
                {
                    hpByName.Add(name, hp);
                    manaPointsByName.Add(name, mp);
                }

                else
                {
                    hpByName[name] += hp;
                    manaPointsByName[name] += mp;
                }

                if (hpByName[name]>100)
                {
                    hpByName[name] = 100;
                    
                }
                if (manaPointsByName[name] > 200)
                {
                    manaPointsByName[name] = 200;
                }

            }

            while (true)
            {
                string inpt = Console.ReadLine();

                if (inpt == "End")
                {
                    break;
                }

                string[] parts = inpt.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];
                string name = parts[1];

                if (command == "CastSpell")
                {
                    
                    int neededMp = int.Parse(parts[2]);
                    string spellName = parts[3];

                    if (manaPointsByName[name]>=neededMp)
                    {
                        manaPointsByName[name] -= neededMp;

                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {manaPointsByName[name]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command== "TakeDamage")
                {
                    
                    int damage = int.Parse(parts[2]);
                    string attacker = parts[3];

                    hpByName[name] -= damage;

                    if (hpByName[name]>0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {hpByName[name]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        hpByName.Remove(name);
                        manaPointsByName.Remove(name);                            
                    }

                }
                else if (command== "Recharge")
                {
                   
                    int amount = int.Parse(parts[2]);
                    int oldAmount = manaPointsByName[name];

                    manaPointsByName[name] += amount;

                    if (manaPointsByName[name] >200)
                    {
                        manaPointsByName[name] = 200;
                        int differrence = 200 - oldAmount;
                        Console.WriteLine($"{name} recharged for {differrence} MP!");
                        continue;
                    }

                    Console.WriteLine($"{name} recharged for {amount} MP!");
                }
                else if (command=="Heal")
                {
                    int amountHp = int.Parse(parts[2]);
                    int oldHp = hpByName[name];
                    hpByName[name] += amountHp;

                    if (hpByName[name]>100)
                    {
                        hpByName[name] = 100;
                        int diff = 100 - oldHp;
                        Console.WriteLine($"{name} healed for {diff} HP!");
                        continue;

                    }

                    Console.WriteLine($"{name} healed for {amountHp} HP!");
                }

            }

            Dictionary<string, int> sorted = hpByName.OrderByDescending(x => x.Value)
                .ThenBy(y => y.Key)
                .ToDictionary(y => y.Key, x => x.Value);

            foreach (var item in sorted)
            {
                string name = item.Key;
                int hp = item.Value;
                int manaPoints = manaPointsByName[name];

                Console.WriteLine(name);
                Console.WriteLine($"  HP: {hp}");
                Console.WriteLine($"  MP: {manaPoints}");
            }

        }
    }
}
