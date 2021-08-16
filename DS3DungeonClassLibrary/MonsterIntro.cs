using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
    public class MonsterIntro : Room
    {
        public static string GetIntro()
        {
            string[] intro =
            {
                "In this sculpted concrete layout you see a {0} ",
                "The {0} tears through the tall brick wall towards you.",
                "Your feet shake as a {0} sprints at you!",
                "You couldn't be mistaken... a {0} has appeared!",

            };//Collection initialization syntax

            return intro[new Random().Next(intro.Length)];
        }
    }
}
