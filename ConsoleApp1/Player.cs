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

        public string Name {  get { return name; } }
        public int Score { get { return this.score; } set { this.score = value; } }

        public Player() 
        {
            this.score = 0;
            Console.WriteLine("Name:");
            string? uinput = Console.ReadLine();
            if (uinput != String.Empty || uinput != null)
                this.name = uinput;
            else
                this.name = $"Anonymus";
        }

       
    }
}
