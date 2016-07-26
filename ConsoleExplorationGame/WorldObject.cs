//A WorldObject is everything that exists in the game.
//Here is gonna have it's NAME, LOCATION, and WHAT.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExplorationGame
{
    public struct Vector2D
    {
        public int x;
        public int y;

        public Vector2D(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
    }
    public enum ObjectType
    {
        Player,
        Wall,
        Enemy,
        Object,
        Default //Default value for when there is not a type assigned;
    };

    public class WorldObject
    {
        public ObjectType objectType;   // TYPE of object
        public string objectName;       // NAME of the object
        public string objectLook;       // LOOK of the object
        public Vector2D objectLocation; // LOCATION of the object
        public static List<WorldObject> worldObjects; //All objects that exist in the GameWorld

        public WorldObject(int x = 0, int y= 0, string n = "Unnamed", ObjectType o = ObjectType.Default, string ol = "")
        {
            objectType = o;
            objectName = n;
            objectLook = ol;
            objectLocation = new Vector2D(x, y);

            worldObjects = new List<WorldObject>();
            //worldObjects.Add(new WorldObject(objectLocation.x, objectLocation.y, objectName,objectType,objectLook));
        }
        
        public static void AddToWorldObjects(WorldObject g)
        {
            worldObjects.Add(g);
        }
    }
}
