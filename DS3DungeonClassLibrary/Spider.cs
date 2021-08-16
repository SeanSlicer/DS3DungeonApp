using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
    public class Spider : Monster
    {
        public bool IsCeilingCrawler { get; set; }

        public Spider(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description, bool isCeilingCrawler)
            : base(name, hitChance, block, life, maxLife, minDamage, maxDamage, description)
        {
            IsCeilingCrawler = isCeilingCrawler;
            if (IsCeilingCrawler)
            {
                Block += 10;
                HitChance += 10;
                Description += "\nIt's attacking from the ceiling!";
            }//end if IsCeilingCrawelr
        }//end FQCTOR
    }
}
