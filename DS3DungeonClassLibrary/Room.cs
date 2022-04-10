using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3DungeonClassLibrary
{
    public class Room
    {
        public static string GetRoom()
        {
            string[] rooms =
            {
                "This small bare chamber holds nothing but a large ironbound chest, which is big enough for a man to fit in and bears a heavy iron lock. The floor has a layer of undisturbed dust upon it.",
                "This chamber was clearly smaller at one time, but something knocked down the wall that separated it from an adjacent room. Looking into that space, you see signs of another wall knocked over. It doesn't appear that anyone made an effort to clean up the rubble, but some paths through see more usage than others.",
                "This otherwise bare room has one distinguishing feature. The stone around one of the other doors has been pulled over its edges, as though the rock were as soft as clay and could be moved with fingers. The stone of the door and wall seems hastily molded together.",
                "You round the corner of the hall to confront a passage nearly blocked with crates, barrels, and chests. It seems someone set them up to barricade the hall. Three barrels are set up as seats near gaps in the barricade.",
                "This hall stinks with the wet, pungent scent of mildew. Black mold grows in tangled veins across the walls and parts of the floor. Despite the smell, it looks like it might be safe to travel through. A path of stone clean of mold wends its way through the hallway.",
                "You catch a whiff of the unmistakable metallic tang of blood as you open the door. The floor is covered with it, and splashes of blood spatter the walls. Some drops even reach the ceiling. It looks fresh, but you don't see any bodies or footprints leaving the chamber.",
                "This tiny room holds a curious array of machinery. Winches and levers project from every wall, and chains with handles dangle from the ceiling. On a nearby wall, you note a pictogram of what looks like a scythe on a chain.",
                "Rounded green stones set in the floor form a snake's head that points in the direction of the doorway you stand in. The body of the snake flows back and toward the wall to go round about the room in ever smaller circles, creating a spiral pattern on the floor. Similar green-stone snakes wend along the walls, seemingly at random heights, and their long bodies make wave shapes.",
                "A chill wind blows against you as you open the door. Beyond it, you see that the floor and ceiling are nothing but iron grates. Above and below the grates the walls extend up and down with no true ceiling or floor within your range of vision. It's as though the chamber is a bridge through the shaft of a great well. Standing on the edge of this shaft, you feel a chill wind pass down it and over your shoulder into the hall beyond.",
                "A cluster of low crates surrounds a barrel in the center of this chamber. Atop the barrel lies a stack of copper coins and two stacks of cards, one face up. Meanwhile, atop each crate rests a fan of five face-down playing cards. A thin layer of dust covers everything. Clearly someone meant to return to their game of cards.",
            };

            return rooms[new Random().Next(rooms.Length)];
        }
    }
}
