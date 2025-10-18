using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Health_Systems_KatelynNicholson
{
    internal class Program
    {

        //Health
        static string healthStatus;
        static int health = 100;
        static int shield = 100;
        static int lives = 3;

        static void Main()
        {
            lives = 3;
            healthStatus = GetHealthStatus(health);


            //Game Play
            ShowHUD(health, healthStatus, shield, lives);
            TakeDamage(50); //damage health, shield
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            Heal(5);
            Console.ReadKey();

            RegenerateShield(5);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            RegenerateShield(5);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            Revive();
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            Heal(5);
            Console.ReadKey();

            RegenerateShield(5);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            RegenerateShield(5);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            Revive();
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            Heal(5);
            Console.ReadKey();

            RegenerateShield(5);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            RegenerateShield(5);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            TakeDamage(50);
            Console.ReadKey();
            Console.Clear();

            ShowHUD(health, healthStatus, shield, lives);
            Console.ReadKey();

            Revive();
            Console.ReadKey();
            Console.Clear();

        }

        static void ShowHUD(int health, string healthStatus, int shield, int lives)
        {
            Console.WriteLine("\n-----------------------HUD-----------------------");
            Console.WriteLine($"Health: {health}, {healthStatus}!");
            Console.WriteLine($"Shield: {shield}");
            Console.WriteLine($"Lives: {lives}");
            Console.WriteLine("-------------------------------------------------\n");
            Console.ReadKey();

        }

        static string GetHealthStatus(int health)
        {
            if (health == 100)
                return "Perfect Health";
            else if (health >= 99)
                return "Healthy";
            else if (health >= 75)
                return "Hurt";
            else if (health >= 50)
                return "Badly Hurt";
            else if (health >= 25)
                return "Imminent Danger";
            else
                return "You Died";
        }

        static void TakeDamage(int damage)
        {
            if (damage <= 0)
            {
                Console.WriteLine("Invalid Damage!");
                return;
            }

            //damage shield first
            if (shield > 0)
            {
                if (damage <= shield)
                {
                    shield -= damage;
                    Console.WriteLine($"Shield took {damage} damage");
                    damage = 0;
                }
                else
                {
                    damage -= shield; //spill over
                    shield = 0;
                }
            }

            //remaining damage hits health
            if (damage > 0)
            {
                health -= damage;
                Console.WriteLine($"You took {damage} damage");
                if (health < 0) health = 0; //clamp

                if (health == 0)
                    Console.WriteLine("You died! use revive to continue");
            }
        }

        static void Heal(int hp)
        {

            if (hp <= 0)
            {
                Console.WriteLine("Invalid Heal!");
                return;
            }

            //if dead
            if (health <= 0)
            {
                Console.WriteLine("You cant heal the dead.");
                return;
            }

            health += hp;

            //health clamp
            if (health > 100)
                health = 100;

            Console.WriteLine($"+{hp} hp");

        }

        static void RegenerateShield(int regen)
        {

            if (regen <= 0)
            {
                Console.WriteLine("Invalid shield regen");
                return;
            }

            shield += regen;
            Console.WriteLine($"+{regen} shield");

            //sheild clamp
            if (shield > 100)
                shield = 100;
            else if (shield < 0)
                shield = 0;

        }

        static void Revive()
        {
            if (health <= 0)
            {
                if (lives > 0)
                {
                    //use a life
                    lives--;

                    //bring back 
                    health = 100;
                    shield = 100;
                    Console.WriteLine($"You've been revived. Lives remaining: {lives}");

                }
                else
                {
                    Console.WriteLine("Game Over!");
                }
            }
        }
    }

}
