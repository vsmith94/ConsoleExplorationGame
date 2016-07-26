using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExplorationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(20,15);

            map.DrawMap();

            Console.ReadLine();
        }
    }
}
