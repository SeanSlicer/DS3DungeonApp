using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
    public class Player : Character
    {
        public Class PlayerClass { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Player(string name, int hitChance, int block, int life, int maxLife, Class playerClass, Weapon equippedWeapon)
            : base(name, hitChance, block, life, maxLife)
        {
            PlayerClass = playerClass;
            EquippedWeapon = equippedWeapon;
            switch (PlayerClass)
            {
                case Class.Knight:
                    MaxLife += 15;
                    Life += 15;
                    HitChance -= 5;
                    Block += 5;
                    break;
                case Class.Mercenary:
                    MaxLife += 15;
                    Life += 15;
                    HitChance -= 5;
                    Block += 5;
                    break;
                case Class.Warrior:
                    MaxLife += 15;
                    Life += 15;
                    HitChance -= 4;
                    Block += 5;
                    break;
                case Class.Herald:
                    MaxLife += 15;
                    Life += 15;
                    HitChance -= 5;
                    Block += 5;
                    break;
                case Class.Thief:
                    MaxLife += 10;
                    Life += 10;
                    HitChance += 8;
                    break;
                case Class.Assassin:
                    MaxLife += 10;
                    Life += 10;
                    HitChance += 7;
                    break;
                case Class.Deprived:
                    MaxLife += 50;
                    Life += 50;
                    HitChance += 35;
                    break;
                default:
                    break;
            }

        }

        public override string ToString()
        {
            return string.Format($"{Name}\nClass: {PlayerClass}\nLife: {Life} of {MaxLife}\nEquipped Weapon:\n {EquippedWeapon}\nHit Chance: {HitChance}\nBlock Chance: {Block}%");
        }

        private static readonly Random rand = new Random();

        public override int CalcDamage()
        {
            int damage;
            lock (rand)
            {
                damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            }
            return damage;
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
