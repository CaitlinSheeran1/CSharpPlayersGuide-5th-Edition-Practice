// Caitlin Sheeran
// 2/12/2025



namespace RockPapeScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count player scores
            int player1Score = 0;
            int player2Score = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("    Welcome to Rock Paper Scissors!   ");
            Console.WriteLine("--------------------------------------");


            while (true)
            {
                // displays the players scores
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine($"Player 1:\t{player1Score}\nPlayer 2:\t{player2Score}");
                Console.WriteLine("--------------------------------------");

                // gets the first player's scores
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Player 1: ");
                string player1Answer = Console.ReadLine().ToUpper();

                // gets the second player's scores
                Console.Write("Player 2: ");
                string player2Answer = Console.ReadLine().ToUpper();

                RockPaperScissors game = new RockPaperScissors(player1Answer, player2Answer);

                // Displays which player won and adds to their score
                if (game.Game(player1Answer, player2Answer) == "Player 1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--------------------------------------");
                    Console.WriteLine("             Player 1 Won!            ");
                    Console.WriteLine("--------------------------------------");
                    player1Score += 1;
                }
                else if (game.Game(player1Answer, player2Answer) == "Player 2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--------------------------------------");
                    Console.WriteLine("             Player 2 Won!              ");
                    Console.WriteLine("--------------------------------------\n");
                    player2Score += 1;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--------------------------------------");
                    Console.WriteLine("            It was a draw!            ");
                    Console.WriteLine("--------------------------------------");
                }

               
            }
        }
        public class RockPaperScissors
        {
            //fields
            private string player1 = "n/a";
            private string player2 = "n/a";

            // gets and sets
            public string Player1
            {
                get { return this.player1; }
                set { this.player1 = value; }
            }
            public string Player2
            {
                get { return this.player2; }
                set { this.player2 = value; }
            }

            // constructors
            public RockPaperScissors(string aPlayer1, string aPlayer2)
            {
                this.player1 = aPlayer1;
                this.player2 = aPlayer2;
            }

            // Methods
            public string Game(string aPlayer1, string aPlayer2)
            {
                // Checks what the player1's score is and compares it to the second players score
                if (aPlayer1 == "ROCK")
                {
                    if (aPlayer2 == "ROCK") return "Draw";
                    else if (aPlayer2 == "PAPER") return "Player 2";
                    else if (aPlayer2 == "SCISSORS") return "Player 1";
                }

                else if (aPlayer1 == "PAPER")
                {
                    if (aPlayer2 == "ROCK") return "Player 1";
                    else if (aPlayer2 == "PAPER") return "Draw";
                    else if (aPlayer2 == "SCISSORS") return "Player 2";
                }

                else if (aPlayer1 == "scissors")
                {
                    if (aPlayer2 == "ROCK") return "Player 2";
                    else if (aPlayer2 == "PAPER") return "Player 1";
                    else if (aPlayer2 == "SCISSORS") return "Draw";
                }
                return "Invalid choice from one of the players";
            }

        }

    }
}
