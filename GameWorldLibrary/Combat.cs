using GameWorldLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameWorldLibrary.MobClass2.MobType;

namespace GameWorldLibrary
{
    public class Combat
    {
        public static void Battle(Entity combatantA, Weapon weaponA, Entity combatantB, Weapon weaponB,int location)
        {

            int attackTurn = 0; // Determine the combatant turn number based on whether it is odd or even. Inititator always goes first.
            bool doCombat = true;
            Console.WriteLine("------COMBAT BEGINS------");
 
            Console.WriteLine($"\n{combatantA.Name}'s HP: {combatantA.HP}\n{combatantB.Name}'s HP: {combatantB.HP}\n"); // Display HPs

            // Combat Loop
            while (doCombat)
            {                

                if (attackTurn % 2 == 0) // Initiator turn when even
                {
                    doCombat = Attack(combatantA,weaponA,combatantB,weaponB,ref attackTurn,location);
                }
                else // Target turn otherwise
                {
                    doCombat = Attack(combatantB, weaponB, combatantA, weaponA, ref attackTurn,location);
                }

            }
            
        }

        public static bool Attack(Entity combatantA, Weapon weaponA, Entity combatantB, Weapon weaponB, ref int attackTurn, int location)
        {
            // Carries out an attack based on the current turn
            // Called by 'Battle'

            Console.WriteLine($"----{combatantA.Name}'s turn----\n");

            Random rand = new Random(); // RNG for crit & attack variance
            string combatSuffix = "";
            int totalDamage;
            int attackVariance;
            int crit = 1;

            // Determine crit
            if (rand.NextDouble() <= 0.1)
            {
                crit = 2;
                combatSuffix += " (Critical)";
            }

            // Attack variance
            attackVariance = rand.Next((int)(weaponA.Damage * 0.5)); // Scale attack variance integer based on weapon damage

            // Use Weapon 
            totalDamage = ((weaponA.Damage + attackVariance) * crit) - combatantB.AC;

            if (Math.Sign(totalDamage) == -1)
            {
                totalDamage = 0; // Prevent damage from unintentionally healing due to armor absorbing all damage done
                combatSuffix += " (No Damage)";
            }

            if (combatantB.HP - totalDamage <= 0)
            {
                combatantB.HP = 0;
            } else
            {
                combatantB.HP -= totalDamage;
            }
                        
            Console.WriteLine($"{combatantA.Name} deals {totalDamage} to {combatantB.Name}" + combatSuffix);
            Console.WriteLine($"\n{combatantA.Name}'s HP: {combatantA.HP}\n{combatantB.Name}'s HP: {combatantB.HP}\n"); // Display HPs
            Console.WriteLine($"----TURN ENDS----\n");

            attackTurn++;

            if (combatantB.HP == 0)
            {
                combatantB.EntityDie(location);
                return false; // End Combat
            }
            return true;
        }

        public static void InitiateCombat(Entity initiator, Entity target,int location)
        {
            // Whoever is the initiator gets to attack first.
            // If the Player is the intitiator, allow them to chose their
            // Weapon before combat begins

            Console.WriteLine($"{target.Name} is being attacked by {initiator.Name}!\n-----------------");

            Weapon weaponA;
            Weapon weaponB;

            // Initiator
            if (initiator is Player)
            {                
                weaponA = Player.SelectWeapon(initiator);
            }
            else
            {
                // TODO Implement support for "Weapon" property in Mob Class
                weaponA = new Weapon(2, "Sharp Rock", "A sharper than usual rock", "Slashing", 1, false, false, 5, UsableType.Weapon);                
            }

            // Target
            if (target is Player)
            {
                weaponB = Player.SelectWeapon(target);
            }
            else
            {
                // TODO Implement support for "Weapon" property in Mob Class
                weaponB = new Weapon(2, "Sharp Rock", "A sharper than usual rock", "Slashing", 1, false, false, 5, UsableType.Weapon);
            }

            Battle(initiator,weaponA,target,weaponB,location);

        }
    }
}