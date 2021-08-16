using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
    public class Weapon
    {
        private int _minDamage;

        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public bool IsTwoHanded { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }//end set
        }//end Min damage
        public Weapon(string name, int bonusHitChance, int minDamage, int maxDamage, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            IsTwoHanded = isTwoHanded;
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\nDamage: {MinDamage} to {MaxDamage}\nHit Modifier: {BonusHitChance}\n{(IsTwoHanded ? "Two" : "One")}-Handed");
        }

    }
}
