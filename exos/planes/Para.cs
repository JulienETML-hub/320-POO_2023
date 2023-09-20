using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planes
{
    class Para
    {

        public string name;
        public int altitude;
        public int longitude;
        public int wind = 2;
        public int speed;
        // View attributes
        private const int PARA_HEIGHT = 6;

        private string[] viewNoParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };
        private string[] viewWithParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };
        private string[] actualPara;
        public void show()
        {

            for (int i = 0; i < this.actualPara.Length; i++)
            {
                Console.SetCursorPosition(this.longitude, this.altitude + i - 6);
                Console.Write(actualPara[i]);
                /*
                 if (parachute is open){
                afficher parachutiste avec parachute}
                else if (parachute is close){
                afficherparachutiste sans parachute}
                 
                 */
               
            }
        }
        public void update()
        {
            if (this.altitude < Config.SCREEN_HEIGHT)
            {
                if (this.altitude < Config.SCREEN_HEIGHT / 2)
                {
                    this.actualPara = viewNoParachute;
                    this.altitude += 2;
                 
                }
                else
                {
                    this.actualPara = viewWithParachute;
                    this.altitude++;
                    if (wind != 0)
                    {
                        this.longitude += wind;
                    }
                }
            }
            else
            {
                this.actualPara = viewNoParachute;
            }
            if (this.longitude >= Config.SCREEN_WIDTH)
            {
                this.longitude = 0;
            }

        }
        /*public int vitesse()
        {
            if(this.actualPara == viewNoParachute)
            {
                this.speed = 50;
            }
            else if (this.actualPara == viewWithParachute)
            {
                this.speed = 100;
            }
            return this.speed;
        }*/



    }


}
