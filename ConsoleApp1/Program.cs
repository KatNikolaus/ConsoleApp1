using System.ComponentModel;
using System.ComponentModel.Design;

namespace ConsoleApp1
{
    enum Direction { vertical=0, horizontal=1 , dia_leftuprightdown= 2, dia_rightupleftdown=3 }
    enum Ship_type { Aircraft_Carrier=5, Battleship=4, Destroyer=3, Patrol_Boat=2, Boat=1 }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ship Sink 1.5:");

            while(true)
            {
                bool q=false;

                Console.WriteLine($"New Game [N] | Quit Game [Q]");

                string? modus = Console.ReadLine();

                switch (modus.ToUpper())
                {
                    case "N":
                        Start();
                        break;
                    case "Q":
                        q = true;
                        break;
                    default: break;
                }

                if (q)
                    break;
            }
        }

        static void Start() 
        {
            bool m;
            int count=0;
            int win;

            // Default Config:
            (int players, int f_dimx, int f_dimy, int ships) config = (2,5,5,1);

            (int x,int y) aim=(config.f_dimy+5,config.f_dimx+5);

            // Init Players:
            Player p1 = new Player();
            Player p2 = new Player();

            int[,] gfield = new int[config.f_dimy,config.f_dimx];


            //Init Ships:
            Ship s1 = new Ship(config.f_dimx,config.f_dimy);
           

            for(int i=0; i<s1.Laength;i++)
            {
                if ((int)s1.D == 0)
                    gfield[s1.Y + i,s1.X] = 1;
                else if ((int)s1.D == 1)
                    gfield[s1.Y,s1.X + i] = 1;
                else if ((int)s1.D == 2)
                    gfield[s1.Y+i,s1.X+i] = 1;
                else if ((int)s1.D == 3)
                    gfield[s1.Y+i,s1.X-i] = 1;
            }

            for(int i=0; i<config.f_dimy;i++)
            {
                for(int j = 0;j < config.f_dimx;j++)
                {
                    if (gfield[i,j]!=1)
                        gfield[i,j] = 0;
                }
            }

            win = s1.Laength;

            while (p1.Score + p2.Score <= win || count > config.f_dimx*config.f_dimy+5)
            {
                Console.Clear();

                Console.WriteLine($"{p1.Name}: Points: {p1.Score} | {p2.Name}: Points: {p2.Score}\n");

                for (int i =0;i < config.f_dimy;i++)
                {
                    for (int j = 0;j < config.f_dimx;j++)
                    {
                        if (gfield[j,i]==0)
                        {
                            if (aim.x == j && aim.y == i)
                            {
                                gfield[j,i] = 2;
                                Console.Write("+");
                                continue;
                            }
                            else
                                Console.Write("O");
                        }
                        if (gfield[j,i]==1)
                        {
                            if (aim.x == j && aim.y == i)
                            {
                                gfield[j,i] = 3;
                                if (count % 2 == 0)
                                    p2.Score++;
                                else
                                    p1.Score++;
                                Console.Write("X");
                                continue;
                            }
                            else
                                Console.Write("O");
                        }
                        if (gfield[j,i] == 2)
                        {
                            Console.Write("+");
                        }
                        if (gfield[j,i] == 3)
                        {
                            Console.Write("X");
                        }

                    }

                    Console.WriteLine();
                }

                if (count % 2 == 0)
                {
                    Console.Write($"\n{p1.Name} ");
                }
                else
                    Console.Write($"\n{p2.Name} ");
                do
                {
                    Console.WriteLine("Aim x-Coordinate: ");
                } 
                while (!int.TryParse(Console.ReadLine(),out aim.x));
                do
                {
                    Console.WriteLine("Aim y-Coordinate: ");
                }
                while (!int.TryParse(Console.ReadLine(),out aim.y));

                count++;
            }

            Console.WriteLine("Game Over!");

            if (p1.Score > p2.Score)
                Console.WriteLine($"{p1.Name} wins with {p1.Score} Points");
            else
                Console.WriteLine($"{p2.Name} win with {p2.Score} Points");
        }
    }
}