using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        // initialize all variables
        Supporting supportClass = new Supporting();
        public char[,] gameBoard = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        public int counter = 0;
        bool player1 = true;
        int[] gameGuesses = new int[9];
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

        // method to play the game. calls the other methods that actually execute the game logic
        public void PlayGame()
        {
            Console.WriteLine("Welcome to the game!");
            PrintBoard();

            // keeps running the game while there is no winner or tie
            int i = 0;
            while (!checkWinner() & counter < 10)
            {
                IterateGame();
                PrintBoard();
                checkWinner();
                i++;
            }
            
        } 
        //checks to make sure the user input is valid
        public bool validateGuess(int userGuess)
        {
            bool isInRange = false;
            bool isNotGuessed = true;
            bool checkGuess = false;
            if (positionLookup.ContainsKey(userGuess))
            {
                isInRange = true;
            }
            if (gameGuesses.Contains(userGuess)){
                isNotGuessed = false;
            }
            if (isNotGuessed && isInRange)
            {
                checkGuess = true;
            }
            return checkGuess;
        }
        // allows each user to take a turn
        public int userInput()
        {
            bool guessValid = false;
            int userGuess = 0;

            while (!guessValid)
            {
                if (player1)
                {
                    Console.Write("Player 1, where do you want to place your guess (Enter 1-9)? ");
                    userGuess = Int32.Parse(Console.ReadLine());

                }
                else
                {
                    Console.Write("Player 2, where do you want to place your guess (Enter 1-9)? ");
                    userGuess = Int32.Parse(Console.ReadLine());
                }

                guessValid = validateGuess(userGuess);
                
            }

            gameGuesses[counter] = userGuess;
            return userGuess;
        }
        
        // adds the user guess to the gameboard
        public void IterateGame()
        {
            
            int userGuess = userInput();
            
            int[] arr;
            if (userGuess > 0 | userGuess < 10)
            {
                arr = positionLookup[userGuess];
                int x = arr[0];
                int y = arr[1];

                counter++;
                if (counter % 2 == 1)
                {
                    gameBoard[x, y] = 'O';
                    player1 = false;
                }
                else
                {
                    gameBoard[x, y] = 'X';
                    player1 = true;
                }
            }
            
        }
        // displays the board
        public void PrintBoard()
        {
            supportClass.DisplayBoard(gameBoard);
        }
        // checks for a winner
        public bool checkWinner()
        {
            bool isWinner = supportClass.CheckWinner(gameBoard);
            if (isWinner)
            {
                if(counter % 2 == 1)
                {
                    Console.WriteLine("Player 1 won!");
                }
                else
                {
                    Console.WriteLine("Player 2 won!");
                }
            }
            return isWinner;
        }

    }
}

