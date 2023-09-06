using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planes
{
    class Plane
    {
        
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        public void show()
        {
            
                for (int i = 0; i < view.Length; i++)
                {
                    
                    Console.WriteLine(view[i]);
                }


        }
         public void move(int _x, int _y) 
         {
            /*int xAvion = _x;
            int yAvion = _y;
            xAvion++;*/
            Console.SetCursorPosition(_x, _y);
            _x++;
            _y++;
             Thread.Sleep(50);
             Console.Clear();

         }

    }
}
