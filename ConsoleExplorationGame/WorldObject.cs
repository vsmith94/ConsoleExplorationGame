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
        int x;
        int y;

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
        public ObjectType objectType;
        public Vector2D objectLocation; 
        public string objectName;
        public string objectLook;
        public static List<WorldObject> worldObjects;

        public WorldObject(Vector2D v, string n = "Unnamed", ObjectType o = ObjectType.Default, string ol = "")
        {
            objectType = o;
            objectName = n;
            objectLocation = v;
            objectLook = ol;

            worldObjects.Add(new WorldObject(objectLocation,objectName,objectType,objectLook));
        }
    }
}
