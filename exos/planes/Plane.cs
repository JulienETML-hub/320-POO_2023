using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planes
{
    class Plane
    {
        public List<Para> paraList = new List<Para>();
        
        public int x = 0;
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
                Console.SetCursorPosition(x, i);
                Console.Write(view[i]);
            }
            
        }
        /* public void move(int _x, int _y) 
         {


            /*int xAvion = _x;
            int yAvion = _y;
            xAvion++;         
            _x++;
            _y++;
             Thread.Sleep(50);
             Console.Clear();
         } */
        public void update()
        { 
            x+=2;
            if (x >= Config.SCREEN_WIDTH)
            {
                x = 0;
            }
            
        }
        public Para jump()
        {
            Para parachutiste = paraList.First();
            parachutiste.altitude = 10;
            parachutiste.longitude = x;
            paraList.Remove(parachutiste);
            
            return parachutiste;
        }

    }
}
