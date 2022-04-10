
namespace DS3DungeonClassLibrary
{
    public static class Weapons
    {
        //Weapons

       public static readonly Weapon swordOfGods = new Weapon("Sword Of The Gods", 100, 100, 100, false);
        public static readonly Weapon shortSword = new Weapon("shortSword", 0, 1, 4, false);
           public static readonly Weapon mace = new Weapon("mace", 10, 4, 10, false);
           public static readonly Weapon claymore = new Weapon("claymore", 0, 7, 13, true);
        public static readonly Weapon zweihander = new Weapon("zweihander", 0, 10, 15, true);
    }
}
