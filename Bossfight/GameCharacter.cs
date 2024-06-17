using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class GameCharacter
    {
        public string Name;
        public int Health;
        public int Strength;
        public int Stamina;
        public int MaxStamina;

        public GameCharacter(string name, int health, int strength, int stamina, int maxStamina)
        {
            Name = name;
            Random random = new Random();
            int bossDamage = random.Next(0, 31);
            Health = health;
            Strength = strength;
            Stamina = stamina;
            MaxStamina = maxStamina;
        }

        public void Fight(GameCharacter opponent)
        {
            if (Stamina > 0 && Health >= 0)
            {
                if(opponent.Health > 0)
                {
                    opponent.Health -= Strength;
                    Stamina -= 10;
                    Console.WriteLine("The " + Name + " hits " + opponent.Name + " for " + Strength + " damage. " + opponent.Name + " has " + (opponent.Health > 0 ? opponent.Health : 0) + " health left.");
                }
            }
            else
            {
                if (Health > 0)
                {
                    Recharge();
                }
                else 
                { 
                    return;
                }
            }
        }

        public void Recharge()
        {
            Stamina = MaxStamina;
            Console.WriteLine();
            Console.WriteLine("The " + Name + " takes a moment to rest and recover their energy");
            Console.WriteLine();
        }

        public bool IsAlive()
        {
            if(Health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
