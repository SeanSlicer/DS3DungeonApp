using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get => _minDamage;
            set =>  _minDamage = value > 0 && value <= MaxDamage ? value : 1; //end set
        }//end Man Damage

        public Monster(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, life, maxLife)
        {
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
        }//end FQCTOR

        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}\n{(Life == MaxLife ? "It is uninjured" : Life <= MaxLife * .25 ? "The monster seems to be close to death" : "It is injured")}");
        }

        private static readonly Random rand = new Random();

        public override int CalcDamage()
        {
            lock (rand)
            {
                return rand.Next(MinDamage, MaxDamage + 1);
            }

        }
    }
}
