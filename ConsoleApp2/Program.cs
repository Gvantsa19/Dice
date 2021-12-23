using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerNumber;
            int enemyNumber;

            int playerPoint = 0;
            int enemyPoint = 0; 

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("please press any key to roll the dice");
                Console.WriteLine("");
                Console.ReadKey();
                playerNumber = random.Next(1, 7);
                Console.WriteLine("player rolled: " + playerNumber);

                Console.WriteLine(".......");
                System.Threading.Thread.Sleep(700);

                enemyNumber = random.Next(1, 7);
                Console.WriteLine("enemy rolled: " + enemyNumber);
                Console.WriteLine("");

                if (playerNumber > enemyNumber)
                {
                    playerPoint++;
                    Console.WriteLine("player won this round!");
                    Console.WriteLine("");
                }
                else if (playerNumber < enemyNumber)
                {
                    enemyPoint++;
                    Console.WriteLine("enemy won this round!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("it is a draw!");
                    Console.WriteLine("");
                }
            }

            if (playerPoint > enemyPoint)
            {
                Console.WriteLine("player won this game!");
            }
            else if (playerPoint < enemyPoint)
            {
                Console.WriteLine("enemy won this game!");

            }
            else
            {
                Console.WriteLine("it is a draw!");
            }

            Console.ReadKey();
        }
    }
}
