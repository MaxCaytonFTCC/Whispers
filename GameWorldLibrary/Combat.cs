using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Combat
    {
        public static void Battle(Player player, Mob mob)
        {
            /*
            // Get the player's weapon of choice
            DisplayRequested.DisplayWeaponInstructions();
            Weapon playerWeapon = Player.SelectWeapon(player);

            int playerDamage = playerWeapon.Damage;
            int mobDamage = World.weapons[int.Parse(mob.Weapon)].Damage;
            int playerHP = player.HP, mobHP = mob.HP;
            Random rand = new Random();

            // Combat Sequence
            int attackTurn = 0; // Determine which entity's turn it is. 0 for player, 1 for mob

            Console.WriteLine("----COMBAT BEGINS----\n");
            Console.WriteLine(player.Name + " HP: " +playerHP+", "+mob.Name+" HP: "+mobHP+" \n");

            while (playerHP > 0 && mobHP > 0) 
            {                
                
                int totalDamage = 0;

                // Combat Turns
                if (attackTurn == 0)
                {
                    totalDamage = rand.Next(playerDamage, playerDamage + 10);

                    mobHP -= totalDamage;
                    Console.Write(player.Name+" Attacks! "+mob.Name+" takes " + totalDamage.ToString() + " damage! ");

                    if (mobHP > 0)
                    {
                        Console.Write(mob.Name+" HP: " + mobHP.ToString() + " \n\n");
                    }
                    else if (mobHP <= 0)
                    {
                        Console.Write(mob.Name+" has died! Overkill: " + Math.Abs(mobHP).ToString() + " \n\n");

                        // Kill the mob
                        World.rooms[player.Location].RoomMobs.Remove(mob);
                    }

                    attackTurn = 1;                    
                }
                else
                {
                    totalDamage = rand.Next(mobDamage, mobDamage + 10);

                    playerHP -= totalDamage;
                    Console.Write(mob.Name+" Attacks! " +player.Name+ " takes " + totalDamage.ToString() + " damage! ");

                    if (playerHP > 0)
                    {
                        Console.Write(player.Name + " HP: " +playerHP.ToString() + " \n\n");
                    }
                    else if (playerHP <= 0)
                    {
                        Console.Write(player.Name + " has died! Overkill: " +Math.Abs(playerHP).ToString() + " \n\n");

                        // Kill the player and make a new one
                        DisplayRequested.DisplayDeathMessage();
                        World.rooms[player.Location].RoomPlayers.Remove(player);                        
                        World.player = new Player(player.ID, player.Name, player.Password, player.Race, player.CombatClass, 100, 0, 0, new List<Item>(), new List<Potion>(), new List<Weapon>(), new List<Treasure>(), new List<string>());
                        World.rooms[0].RoomPlayers.Add(World.player);
                    }

                    attackTurn = 0;                    
                }                

            }
            
            Console.WriteLine("----COMBAT ENDS----\n");
            */
        }
    }
}