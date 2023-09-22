using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Canon
    {
        public int x;
        public int y;

        public Canon(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void deplacement()
        {

            ConsoleKeyInfo input = Console.ReadKey();
            
            switch (input.Key)
            {
                case ConsoleKey.LeftArrow:
                    this.x--;
                    break;

                case ConsoleKey.RightArrow:
                    this.x++;
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;

 

            }

        }
    }
}
