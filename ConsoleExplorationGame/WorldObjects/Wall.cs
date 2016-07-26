using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExplorationGame.WorldObjects
{
    public class Wall : WorldObject
    {
        public Wall(Vector2D v)
        {
            objectName = "Wall";
            objectType = ObjectType.Wall;
            objectLook = "#";
            objectLocation = v;
        }
    }
}
