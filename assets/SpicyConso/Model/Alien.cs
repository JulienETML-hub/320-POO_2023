using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Alien
    {
        public int x;
        public int y;

        public Alien(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move()
        {
            x = (x + 1) % 10;
            y = (y + 1) % 15;
        }
    }
}
