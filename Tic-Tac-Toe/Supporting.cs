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
    }
}
