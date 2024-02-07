using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Field
    {
        int Dim_x;
        int Dim_y;

        int[,] Gfield;

        int No_ships;
        int No_player;

        public Field()
        {
            bool ctr=false;

            do
            {
                Console.WriteLine("Load Default-Config? [Y/N]");
                string uinput = Console.ReadLine().ToUpper();

                if (uinput == "Y")
                {
                    this.Dim_x = 5;
                    this.Dim_y = 5;

                    this.Gfield = new int[this.Dim_y,this.Dim_y];

                    this.No_ships = 1;
                    this.No_player = 2;

                }
                else if (uinput == "N")
                {
                    do
                    {
                        Console.WriteLine("Field-x-Dim:");

                    }
                    while (int.TryParse(Console.ReadLine(),out this.Dim_x));

                    do
                    {
                        Console.WriteLine("Field-y-Dim:");

                    }
                    while (int.TryParse(Console.ReadLine(),out this.Dim_y));
                    do
                    {
                        Console.WriteLine($"Num of Ships: [1,{0.3 * this.Dim_x * this.Dim_y}]");

                    }
                    while (int.TryParse(Console.ReadLine(),out this.No_ships) && this.No_ships > 0 && this.No_ships < 0.3 * this.Dim_x * this.Dim_y);
                    do
                    {
                        Console.WriteLine("Num of Players:");

                    }
                    while (int.TryParse(Console.ReadLine(),out this.No_player));
                }
                else
                {
                    Console.WriteLine("Wrong Input!");
                    ctr = true;
                }
            }while (ctr);
        }
    }
}
