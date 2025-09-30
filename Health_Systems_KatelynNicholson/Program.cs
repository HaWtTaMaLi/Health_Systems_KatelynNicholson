using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Health_Systems_KatelynNicholson
{
    internal class Program
    {
        static int health = 100;
        static int sheild = 100;
        static int[] healthStatus = { 1, 101};
        static int[] lives = { 1, 4 };


        static void Main()
        {

        }

        static void SHowHUD(int healthStatus)
        {
            //shows HUD
            //shows health, sheild, lives
            // shows health as a number 0 > 100%
            //show health as a string as follows:
            //health int = 10 imminent danger
            // = 50 badly hurt
            //= 75 hurt
            //=90 healthy
            // =100 perfect health
        }

        static void TakeDamage()
        {
            //modifies health, shield
            //shield depletes first
            //health depletes second
            //spill over effect: damage greater than remaining shield spills onto to health
            //does not deplete lives when health reaches 0-- use Revive() (new!)
            //does not reset shield and health to default values when you die --use Revive()(new!)
            //based on parameter input(input describes how much damage is taken)
            //range checking
            //error checking
        }

        static void heal(int hp)
        {
            //modifies health
            //based on parameter input(input describes how much player is healed)
            //range checking
        }

        static int RegenerateSheild(int hp)
        {
            //regen sheild
            //modifies shield
            //based on parameter input(input describes how much shield should regenerate)
            //range checking
            //error checking
        }

        static void Revive()
        {
            //esets shield and health to default values
            //uses up one life(new!)
            //bringing a player back using a left-over life
            //should be called when you die
        }

        //error checking = handles(incorrectly) passing in negative numbers, such as TakeDamage(-10)
        //display error message that describes what happened
        //do not modify values
        //no actual gameplay required
        //no hard coding


/*Extra Mile - XP/Level Up System - Technical Specifications:

variables:
xp integer; 0.. (new!)
level integer; 1.. (new!)
methods:
IncreaseXP(int exp) method
 modifies xp and level
leveling up uses up xp -- this make it easier to code(new!)
ShowHUD() method extended
shows previous stats(see health system for reference)
shows xp
shows level
xp/level design:
same design as before, only now costs xp to level up -- easier to code(new!)
start at 0 xp
start at level 1
at level 1, costs 100 xp to level up to level 2
at level 2, costs 200 xp to level up to level 3
at level 3, costs 300 xp to level up to level 4
etc.
no hard coding*/
    }
}
