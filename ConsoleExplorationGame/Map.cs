using System;
using ConsoleExplorationGame.WorldObjects;
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

        public void DrawMap()
        {
            for (int j = 1; j <= mapDimensions.y; j++)
            {
                for (int i = 1; i <= mapDimensions.x; i++)
                {
                    //Draw Walls
                    if ((!(i >= 2 && j >= 2) || (i == mapDimensions.x || j == mapDimensions.y)))
                    {                        
                        //Wall w = new Wall(new Vector2D(i, j));
                        WorldObject.worldObjects.Add(new Wall(new Vector2D(i,j)));
                        Console.Write("#"); //Wall symbol as there is no object reference
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
