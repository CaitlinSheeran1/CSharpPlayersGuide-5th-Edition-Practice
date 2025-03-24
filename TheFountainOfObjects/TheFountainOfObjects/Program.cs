// Caitlin Sheeran
// 2/25/2025

// For expansions  I added a small, medium, and large game
//                 Then I added pits to the game
//                 Getting Help with my own spin

using System;
using System.Data;
using TheFountainOfObjects;

namespace TheFountainOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string worldChoice;

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("   Welcome! Your goal is to find ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The Fountain of Objects");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("   You can either move ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tnorth\teast\tsouth\twest");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("          Once it is avtivated you can leave!");
                Console.WriteLine("-----------------------------------------------------------");

                Console.Write("Would you like to play on small, medium, or large world?: ");
                worldChoice = Console.ReadLine();

                Console.Write("           Press any key once you are ready!");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            bool playingGame = true;
            MoveGrid player = new MoveGrid(0, 0, false, worldChoice);

            while (playingGame == true)
            {

                Console.WriteLine("-----------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(player.DisplaySpot());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Which direction would you like to move in?: ");


                string answer = Console.ReadLine();
                player.MoveInCave(answer);
                Console.WriteLine("-----------------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(player.SpotInCave());
                Console.ForegroundColor = ConsoleColor.White;

                if (player.FountainActivated() && player.AtEntrance())
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("The Fountain of Objects has been reactivated,\nand you have escaped with your life!\nYou win!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("-----------------------------------------------------------");
                    break;
                }
                else if (player.Pit() == true)
                {
                    Console.WriteLine("You fell into a pit! You lose!");
                    break;
                }


            }
            Console.ReadKey();


        }
    }
    public class MoveGrid
    {
        private int row = 0;
        private int col = 0;
        private bool fountain = false;
        private string worldChoice;

        public int Row { get { return this.row; } set { this.row = value; } }
        public int Col { get { return this.col; } set { this.col = value; } }
        public bool Fountain { get { return this.fountain; } set { this.fountain = value; } }
        public string WorldChoice { get { return this.worldChoice; } set { this.worldChoice = value; } }

        public MoveGrid(int aRow, int aCol, bool aFountain, string aWorldChoice)
        {
            this.row = aRow; this.col = aCol; this.fountain = aFountain; this.worldChoice = aWorldChoice;
        }

        public void MoveInCave(string PlayerChoice)
        {

            int newRow = row;
            int newCol = col;

            if (PlayerChoice == "move north") newRow--;
            else if (PlayerChoice == "move east") newCol++;
            else if (PlayerChoice == "move south") newRow++;
            else if (PlayerChoice == "move west") newCol--;
            else
            {
                Console.WriteLine(CantMove());
                return;
            }

            if (worldChoice == "small")
            {
                if (newRow < 0 || newRow > 3 || newCol < 0 || newCol > 3) Console.WriteLine(CantMove());
                else row = newRow; col = newCol;
            }
            else if (worldChoice == "medium")
            {
                if (newRow < 0 || newRow > 6 || newCol < 0 || newCol > 6) Console.WriteLine(CantMove());
                else row = newRow; col = newCol;
            }
            else if (worldChoice == "large")
            {
                if (newRow < 0 || newRow > 8 || newCol < 0 || newCol > 8) Console.WriteLine(CantMove());
                else row = newRow; col = newCol;
            }


        }
        public string SpotInCave()
        {
            
            if (worldChoice == "small")
            {
                if (row == 0 && col == 0)
                {
                    AtEntrance();
                    Console.ForegroundColor = ConsoleColor.Green;
                    return "You see light coming from the cavern entrance.";
                }

                else if (row == 0 && col == 2)
                {
                    if (fountain == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-----------------------------------------------------------");
                        FountainOfObjects();
                        if (fountain == false)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            return "The fountain is not activated";
                        }
                        else
                        {
                            fountain = true;
                            Console.ForegroundColor = ConsoleColor.White;
                            return "The fountain is activated!";
                        }


                    }
                    else return "You hear rushing waters from the Fountain of Objects. It has been reactivated!";

                }
                else if (row == 2 && col == 2)
                {
                    Pit();
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "You lost! You fell into a pit";
                }

                else if ((row == 1 && col == 1) || (row == 1 && col == 2) || (row == 1 && col == 3) ||
                         (row == 2 && col == 1) || (row == 3 && col == 1) || (row == 3 && col == 2) ||
                         (row == 3 && col == 3) || (row == 2 && col == 3))
                {
                    return "You feel a draft. There is a pit in a nearby room.";
                }


                else
                {

                    return "You can't see anything.";
                }
            }











            else if (worldChoice == "medium")
            {
                if (row == 0 && col == 0)
                {
                    AtEntrance();
                    Console.ForegroundColor = ConsoleColor.Green;
                    return "You see light coming from the cavern entrance.";
                }

                else if (row == 4 && col == 2)
                {
                    if (fountain == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-----------------------------------------------------------");
                        FountainOfObjects();
                        if (fountain == false)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            return "The fountain is not activated";
                        }
                        else
                        {
                            fountain = true;
                            Console.ForegroundColor = ConsoleColor.White;
                            return "The fountain is activated!";
                        }


                    }
                    else return "You hear rushing waters from the Fountain of Objects. It has been reactivated!";

                }

                else if (row == 1 && col == 4)
                {
                    Pit();
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "You lost! You fell into a pit";
                }

                else if ((row == 0 && col == 3) || (row == 0 && col == 4) || (row == 0 && col == 5) ||
                         (row == 1 && col == 3) || (row == 1 && col == 5) || (row == 2 && col == 3) ||
                         (row == 2 && col == 4) || (row == 2 && col == 5))
                {
                    return "You feel a draft. There is a pit in a nearby room.";
                }
                else if (row == 4 && col == 4)
                {
                    Pit();
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "You lost! You fell into a pit";
                }

                else if ((row == 3 && col == 3) || (row == 3 && col == 4) || (row == 3 && col == 5) ||
                         (row == 4 && col == 3) || (row == 4 && col == 5) || (row == 5 && col == 3) ||
                         (row == 5 && col == 4) || (row == 5 && col == 5))
                {
                    return "You feel a draft. There is a pit in a nearby room.";
                }

                else return "You can't see anything.";
            }










            else
            {
                if (row == 0 && col == 0)
                {
                    AtEntrance();
                    Console.ForegroundColor = ConsoleColor.Green;
                    return "You see light coming from the cavern entrance.";
                }

                else if (row == 6 && col == 6)
                {
                    if (fountain == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-----------------------------------------------------------");
                        FountainOfObjects();
                        if (fountain == false)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            return "The fountain is not activated";
                        }
                        else
                        {
                            fountain = true;
                            Console.ForegroundColor = ConsoleColor.White;
                            return "The fountain is activated!";
                        }


                    }
                    else return "You hear rushing waters from the Fountain of Objects. It has been reactivated!";

                }



                else if (row == 1 && col == 2)
                {
                    Pit();
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "You lost! You fell into a pit";
                }

                else if ((row == 0 && col == 1) || (row == 0 && col == 2) || (row == 0 && col == 3) ||
                         (row == 1 && col == 1) || (row == 1 && col == 3) || (row == 2 && col == 1) ||
                         (row == 2 && col == 2) || (row == 2 && col == 3))
                {
                    return "You feel a draft. There is a pit in a nearby room.";
                }



                else if (row == 1 && col == 6)
                {
                    Pit();
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "You lost! You fell into a pit";
                }

                else if ((row == 0 && col == 5) || (row == 0 && col == 6) || (row == 0 && col == 7) ||
                         (row == 1 && col == 5) || (row == 1 && col == 7) || (row == 2 && col == 5) ||
                         (row == 2 && col == 6) || (row == 2 && col == 7))
                {
                    return "You feel a draft. There is a pit in a nearby room.";
                }



                else if (row == 4 && col == 6)
                {
                    Pit();
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "You lost! You fell into a pit";
                }

                else if ((row == 3 && col == 5 || (row == 3 && col == 6) || (row == 3 && col == 7) ||
                         (row == 4 && col == 5) || (row == 4 && col == 7) || (row == 5 && col == 5) ||
                         (row == 5 && col == 6) || (row == 5 && col == 7)))
                {
                    return "You feel a draft. There is a pit in a nearby room.";
                }



                else if (row == 6 && col == 1)
                {
                    Pit();
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "You lost! You fell into a pit";
                }

                else if ((row == 5 && col == 0) || (row == 5 && col == 1) || (row == 5 && col == 2) ||
                         (row == 6 && col == 0) || (row == 6 && col == 2) || (row == 7 && col == 0) ||
                         (row == 7 && col == 1) || (row == 7 && col == 2))
                {
                    return "You feel a draft. There is a pit in a nearby room.";
                }






                else return "You can't see anything.";
            }
        }
        
        public string DisplaySpot()
        {
            Console.WriteLine($"You are in room at (Row={row}, Column={col})");
            Console.ForegroundColor = ConsoleColor.White;
            return "-----------------------------------------------------------";
        }
        public string CantMove()
        {
            Console.WriteLine("-----------------------------------------------------------");
            return "Unable to move in that direction. Maybe try another direction?";
        }
        public void FountainOfObjects()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Would you like to enable the fountain?: ");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "YES") { fountain = true; break; }
                else if (answer == "NO") { fountain = false; break; }
                else Console.WriteLine("Not a valid answer. Please type yes or no");
            }

        }
        public bool Pit()
        {
            if ((worldChoice == "small" && row == 2 && col == 2) ||
                (worldChoice == "medium" && (row == 1 && col == 4 || row == 4 && col == 4)) ||
                (worldChoice == "large" && (row == 1 && col == 2 || row == 1 && col == 6 ||
                                            row == 4 && col == 6 || row == 6 && col == 1)))
            {
                return true; 
            }
            return false; 
        }
        public bool FountainActivated()
        {
            return fountain;
        }
        public bool AtEntrance()
        {
            return row == 0 && col == 0;
        }
    }
}
