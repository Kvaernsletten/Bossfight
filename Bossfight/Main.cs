using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class Main
    {
        Random random = new Random();
        int bossDamage;
        GameCharacter hero;
        GameCharacter boss;


        public void Run()
        {
            bossDamage = random.Next(0, 31);
            hero = new GameCharacter("Hero", 100, 20, 40, 40);
            boss = new GameCharacter("Boss", 400, bossDamage, 10, 10);

            Console.WriteLine("wut do?");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Exit");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Battle();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            };
        }

        public void Battle()
        {
            while (hero.IsAlive() && boss.IsAlive())
            {
                hero.Fight(boss);
                boss.Fight(hero);

                if (!hero.IsAlive())
                {
                    Console.WriteLine(hero.Name + " drops dead and the world is doomed to burn in eternal fire for all ages to come.");
                }else if (!boss.IsAlive())
                {
                    Console.WriteLine(hero.Name + " vanquishes " + boss.Name + " and epic loot explodes and spreads across the room.. everyone is rich af. GG & GZ");
                }
            }
        }

    }
}
