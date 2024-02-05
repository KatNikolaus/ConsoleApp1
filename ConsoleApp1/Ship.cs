using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Ship
    {
        public ship_type stype { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public direction d { get; set; }
        public int laength { get; set; }


        public Ship(int f_dimx,int f_dimy)
        {
            Random r1 = new Random(5);
            Random r2 = new Random();
            Random r3 = new Random(4);

            if (r1.Next() <= 1)
                this.stype = ship_type.Boat;
            else if (r1.Next() <= 2)
                this.stype = ship_type.Patrol_Boat;
            else if (r1.Next() <= 3)
                this.stype = ship_type.Destroyer;
            else if (r1.Next() <= 4)
                this.stype = ship_type.Battleship;
            else if (r1.Next() <= 5)
                this.stype = ship_type.Aircraft_Carrier;
            this.x = r2.Next(f_dimx);
            this.y = r2.Next(f_dimy);
            if (r3.Next() < 1)
                this.d = direction.vertical;
            if (r3.Next() < 2)
                this.d = direction.horizontal;
            if (r3.Next() < 3)
                this.d = direction.dia_leftuprightdown;
            if (r3.Next() < 4)
                this.d = direction.dia_rightupleftdown;
        }

    }

}