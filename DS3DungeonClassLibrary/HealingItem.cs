using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
    public class HealingItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HealingAmount { get; set; }
        
        public HealingItem(string name, string description, int healingAmount)
        {
            Name = name;
            Description = description ;
            HealingAmount = healingAmount;
            
        }//end FQCTOR
        public override string ToString()
        {
            return string.Format($"");
        }

    }
}
