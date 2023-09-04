using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    class MobClass2
    {
        ///MobType mobType = new MobType();
        //mobType.EnemyType("Bear", "Looters", "Fungal Mob", "Patrol Troops", "Wild Dogs");
        //mobType.MobHP(100, 50, 80, 75, 0);

        public class MobType
        {
            //The enemy type (enemy class)
            private string _wildbear = "Bear";
            private string _looters = "Looters";
            private string _fungalmob = "Fungal Mob";
            private string _patroltroops = "Patrol Troops";
            private string _wilddogs = "Wild Dogs";
            public string WildBear { get { return _wildbear; } set { _wildbear = value; } }
            public string Looters { get { return _looters; } set { _looters = value; } }
            public string FungalMob { get { return _fungalmob; } set { _fungalmob = value; } }
            public string Patroltroops { get { return _patroltroops; } set { _patroltroops = value; } }
            public string WildDogs { get { return _wilddogs; } set { _wilddogs = value; } }

            //The enemy Health at the start
            private int fullHP = 100;
            private int halfHP = 50;
            private int reducedHP = 80;
            private int slightHP = 75;
            private int noHP = 0;
            public int FullHP { get { return fullHP; } set { fullHP = value; } }
            public int HalfHP { get { return halfHP; } set { halfHP = value; } }
            public int ReducedHP { get { return reducedHP; } set { reducedHP = value; } }
            public int SlightHP { get { return slightHP; } set { slightHP = value; } }
            public int NoHP { get { return noHP; } set { noHP = value; } }

            public int MobHP(int full, int half, int reduce, int slight, int no)
            {
                MobType mob = new MobType
                {
                    FullHP = full,
                    HalfHP = half,
                    ReducedHP = reduce,
                    SlightHP = slight,
                    NoHP = no,
                };

                Random rand = new Random();
                int opHP = rand.Next(0, 5);

                switch (opHP)
                {
                    case 1:
                        Console.WriteLine("Full health: " + full);
                        break;
                    case 2:
                        Console.WriteLine("Half health: " + half);
                        break;
                    case 3:
                        Console.WriteLine("Reduced health: " + reduce);
                        break;
                    case 4:
                        Console.WriteLine("Slight Health: " + slight);
                        break;
                    case 5:
                        Console.WriteLine("Zero Health Points: " + no);
                        break;
                }
                return opHP;
            }

            public void EnemyType(string bear, string looter, string fungal, string patrol, string dogs)
            {
                MobType mob = new MobType
                {
                    WildBear = bear,
                    Looters = looter,
                    FungalMob = fungal,
                    Patroltroops = patrol,
                    WildDogs = dogs,
                };

                Random rand = new Random();
                int enemy = (rand.Next(0, 5));

                switch (enemy)
                {
                    case 1:
                        Console.WriteLine("A Wild Bear has appeared!");
                        break;
                    case 2:
                        Console.WriteLine("A group of Looters are on the move ");
                        break;
                    case 3:
                        Console.WriteLine("A Fungal Mob is in the area!");
                        break;
                    case 4:
                        Console.WriteLine("Patrol Troops are on a patrol");
                        break;
                    case 5:
                        Console.WriteLine("A pack of Wild Dogs have appeared!");
                        break;
                }
                //return enemy;
            }
        }
    }
}
