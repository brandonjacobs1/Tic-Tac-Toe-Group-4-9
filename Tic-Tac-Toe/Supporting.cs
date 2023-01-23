using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Supporting
    {
        //Just making a comment to test the git features
        
        //Display Board method, intakes a 2d array
        public void DisplayBoard(char[,] array)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + array[0, 0] + "  |  " + array[0, 1] + "  |  " + array[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + array[1, 0] + "  |  " + array[1, 1] + "  |  " + array[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + array[2, 0] + "  |  " + array[2, 1] + "  |  " + array[2, 2]);
            Console.WriteLine("     |     |      ");
        }

        public bool CheckWinner (char[,] array)
        {

            //Checking the horizontal and vertical spaces to see if there is a winner
            for (int i = 0; i < 3; ++i)
            {
                if ((array[i,0] == array[i,1] && array[i,1] == array[i, 2]) | (array[0, i] == array[1, i] && array[1, i] == array[2, i]))
                {
                    Console.WriteLine("Winner Place Holder Text");
                    return true;

                }

                //Checking the diagonal spaces to see if there is a winner
                else if ((array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2]) | (array[2, 0] == array[1, 1] && array[1, 1] == array[0, 2]))
                {
                    Console.WriteLine("Winner Place Holder Text");
                    return true;
                }

            }

            //If they don't win, false is returned
            return false;


        }
    }
}
