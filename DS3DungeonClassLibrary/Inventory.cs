using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS3DungeonClassLibrary;

namespace DS3DungeonClassLibrary
{
    public class Inventory
    {
        public static List<Weapon> inventoryWeapons { get; set; }  = new List<Weapon>();
        public List<HealingItem> healingItems { get; set; } = new List<HealingItem>();

        public override string ToString()
        {
            return "";
        }

    }
}
