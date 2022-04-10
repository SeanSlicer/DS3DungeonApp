using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{

    public static class Monsters
    {
       public static Random rand = new Random();

        //lothric Monster List
        public static readonly Monster lothric_Knight = new Monster("Lothric Knight", 30, 4, 15, 15, 1, 5, "Knight of Lothric Castle");
           public static readonly Monster dog = new Monster("Dog", 45, 4, 5, 5, 1, 2, "A scrawny ferocious dog peering at you for food");
           public static readonly Spider deepAccursed = new Spider("Deep Accursed", 40, 15, 15, 10, 3, 7, "Large 6 legged spider, reminiscent of a dog.", rand.Next(2) == 1);
           public static readonly Spider sewerCentipede = new Spider("Sewer Centipede", 65, 5, 10, 10, 1, 4, "a lifeless, pale body with 8 legs on both sides and hair covering the head.", rand.Next(2) == 1);

            //Undead Settlement Monster List
            public static readonly Monster thrall = new Monster("Thrall", 30, 4, 15, 15, 1, 5, "A small hooded creature carrying a knife.");
            public static readonly Monster evangelist = new Monster("Evangelist", 45, 4, 5, 5, 1, 2, "A large Witch carrying a spiked metal mace.");
            public static readonly Monster rootSkeleton = new Monster("Root Skeleton", 40, 15, 15, 10, 3, 7, "A gnarled looking skeleton with maggots inside.");
        public static readonly Monster hallowManServant = new Monster("Hollow Manservant", 65, 5, 10, 10, 1, 4, "A large skeletonized looking creature with a red cloak on and a cage on his back.");

            //Boss list
            public static readonly Monster Vordt = new Monster("Vordt Of The Boreal Valley", 85, 0, 100, 100, 1, 1, "A large armored dog like creature, He has a large, frosted, spiked hammer who guards the undead settlement.");
    }
}
