using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Ship
    {
        public Ship_type Stype { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Direction D { get; set; }
        public int Laength { get; set; }


        public Ship(int f_dimx,int f_dimy)
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();

            int typ = r1.Next(5);

            if (typ <= 1)
                this.Stype = Ship_type.Boat;
            else if (typ <= 2)
                this.Stype = Ship_type.Patrol_Boat;
            else if (typ <= 3)
                this.Stype = Ship_type.Destroyer;
            else if (typ <= 4)
                this.Stype = Ship_type.Battleship;
            else if (typ <= 5)
                this.Stype = Ship_type.Aircraft_Carrier;

            this.X = r2.Next(f_dimx);
            this.Y = r2.Next(f_dimy);

            int d = r3.Next(5);

            if (d < 1)
                this.D = Direction.vertical;
            else if (d < 2)
                this.D = Direction.horizontal;
            else if (d < 3)
                this.D = Direction.dia_leftuprightdown;
            else if (d < 4)
                this.D = Direction.dia_rightupleftdown;

            this.Laength = (int) this.Stype;
        }

    }

}