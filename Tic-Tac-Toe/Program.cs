using System;
namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver game = new Driver();
            game.PlayGame();


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(game.gameBoard[i, j]);
                }
                Console.WriteLine();
            }






        }
    }
}
