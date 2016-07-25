using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExplorationGame
{
    public class Map
    {

        public Vector2D mapDimensions;

        public Map(int x = 10, int y = 15)
        {
            mapDimensions = new Vector2D(x, y);
        }

        public static void DrawMap()
        {

        }
    }
}
