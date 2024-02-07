using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        string name;
        int score;
        public int Aim_x { get; set; }
        public int Aim_y {  get; set; }

        public string Name {  get { return name; } }
        public int Score { get { return this.score; } set { this.score = value; } }

        public Player() 
        {
            this.score = 0;
            Console.WriteLine("Name:");
            string? uinput = Console.ReadLine();
            if (!String.IsNullOrEmpty(uinput))
                this.name = uinput;
            else
                this.name = $"Anonymus";
        }

        public (int x, int y) Aim() 
        {
            int x,y;
            do
            { 
                Console.WriteLine($"{this.Name}: Your Aim-X-Coordinate:"); 
            }
            while (int.TryParse(Console.ReadLine(),out x));
            do
            {
                Console.WriteLine($"{this.Name}: Your Aim-Y-Coordinate:");
            }
            while (int.TryParse(Console.ReadLine(),out y));

            this.Aim_x = x;
            this.Aim_y = y;

            return (x,y);

        }
    }
}
