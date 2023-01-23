using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    // Welcome the user to the game
    // Create a game board array to store the players’ choices
    // Ask each player in turn for their choice and update the game board array
    // Print the board by calling the method in the supporting class
    // Check for a winner by calling the method in the supporting class, and notify the players
    // when a win has occurred and which player won the game

    class Driver
    {
        public char[,] gameBoard = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        public int counter = 0;

        int[] position = new int[2];

        public Dictionary<int, int[]> positionLookup = new Dictionary<int, int[]>()
        {
            {1, new int[] {0,0} },
            {2, new int[] {0,1} },
            {3, new int[] {0,2} },
            {4, new int[] {1,0} },
            {5, new int[] {1,1} },
            {6, new int[] {1,2} },
            {7, new int[] {2,0} },
            {8, new int[] {2,1} },
            {9, new int[] {2,2} }

        };
        public void StartGame()
        {
            Console.WriteLine("Welcome to the game!");
        } 
        public int userInput()
        {
            Console.Write("Where do you want to place your guess (Enter 0-9)? ");
            int userGuess =  Int32.Parse(Console.ReadLine());

            return userGuess;
        }
        public void IterateGame()
        {
            int userGuess = userInput();
            
            int[] arr;
            arr = positionLookup[userGuess];
            int x = arr[0];
            int y = arr[1];

            counter++;
            //use mod to alternate players

            gameBoard[x,y] = 'x';
            
        }
    }
}

