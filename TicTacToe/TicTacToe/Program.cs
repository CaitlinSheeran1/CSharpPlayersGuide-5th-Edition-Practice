// Caitlin Sheeran
// 2/13/2025

using System.Data;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displays the game and what number the sqaure is
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("These are the numbers of the spaces!\n");
            Console.WriteLine($"             1 | 2 | 3 \n" +
                              $"            -----------\n" +
                              $"             4 | 5 | 6 \n" +
                              $"            -----------\n" +
                              $"             7 | 8 | 9 \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------");

            // This makes it so the above message displays before PlayGame is called
            while (true)
            {
                Console.Write("Please enter start to play: ");
                string userChoice = Console.ReadLine();
                if (userChoice == "start")
                {
                    
                    TicTacToe game = new TicTacToe(1, 2);
                    game.PlayGame();
                }
            }



        }

        public class TicTacToe
        {
            //fields
            private int player1Number = -1;
            private int player2Number = -1;
            private string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " " }; 

            public int Player1Number
            {
                get { return this.player1Number; }
                set { this.player1Number = value; }
            }
            public int Player2Number
            {
                get { return this.player2Number; }
                set { this.player2Number = value; }
            }
            public string[] Board
            {
                get { return this.board; }
                set { this.board = value; } 
            }

            // Constructor
            public TicTacToe(int aPlayer1Number, int aPlayer2Number)
            {
                this.player1Number = aPlayer1Number;
                this.player2Number = aPlayer2Number;
            }

            // Methods
            public void GameTiles(int aPlayerNumber, string symbol)
            {
                // Makes sure player enters a number between 1-9
                if (aPlayerNumber < 1 || aPlayerNumber > 9 || board[aPlayerNumber - 1] != " ")
                {
                    Console.WriteLine("Not valid");
                    return;
                }

                switch (aPlayerNumber)
                {
                    case 1: board[0] = symbol; break;
                    case 2: board[1] = symbol; break;
                    case 3: board[2] = symbol; break;
                    case 4: board[3] = symbol; break;
                    case 5: board[4] = symbol; break;
                    case 6: board[5] = symbol; break;
                    case 7: board[6] = symbol; break;
                    case 8: board[7] = symbol; break;
                    case 9: board[8] = symbol; break;
                    default: Console.WriteLine("Invalid move!"); break;
                }
            }

            // Displays the board
            public void DisplayBoard()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"            {board[0]} | {board[1]} | {board[2]}");
                Console.WriteLine("            ---------");
                Console.WriteLine($"            {board[3]} | {board[4]} | {board[5]}");
                Console.WriteLine("            ---------");
                Console.WriteLine($"            {board[6]} | {board[7]} | {board[8]}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------------------");
            }

            // reads the player move
            public void PlayGame()
            {
                int currentPlayer = 1;
                int moves = 0;

                while (moves < 9)
                {
                    Console.Clear();
                    DisplayBoard();
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.Write($"\nPlayer {currentPlayer}, enter your move (1-9): ");

                    if (int.TryParse(Console.ReadLine(), out int position)) // Used google to figure this out
                    {
                        if (currentPlayer == 1)
                        {
                            GameTiles(position, "X");
                            currentPlayer = 2;
                        }
                        else
                        {
                            GameTiles(position, "O");
                            currentPlayer = 1;
                        }
                        moves++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number 1-9");
                    }
                }

                Console.Clear();
                DisplayBoard();
                Console.WriteLine("\nGame Over!");
            }
        }

    }
}
