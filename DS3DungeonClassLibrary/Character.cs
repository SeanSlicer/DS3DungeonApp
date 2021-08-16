using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
        public abstract class Character
        {

            private int _life;

            public string Name { get; set; }
            public int HitChance { get; set; }
            public int Block { get; set; }
            public int MaxLife { get; set; }

            public int Life
            {
                get => _life;
                set => _life = value > MaxLife ? MaxLife : value;
            }//end life


        public Character(string name, int hitChance, int block, int life, int maxLife)
            {
                MaxLife = maxLife;
                Name = name;
                HitChance = hitChance;
                Block = block;
                Life = life;
            }

            public virtual int CalcBlock()
            {
                return Block;
            }

            public virtual int CalcHitChance()
            {
                return HitChance;
            }

            public abstract int CalcDamage();
        }
}
