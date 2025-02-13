// Caitlin Sheeran
// 2/12/2025


using System.Linq.Expressions;

namespace TheLockedDoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a passcode for the door and creates a door object

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Please select a passcode for the door: ");
            int passcode = Convert.ToInt32(Console.ReadLine());
            Door userDoor = new Door(passcode);
            Console.Clear();



            while (true)
            {
                // Tells the user what state the door is in and asks for an action
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine($"The door is {userDoor.DoorAction}. Please select Lock, Unlock, Open, Close, or Change Password");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                string answer = Console.ReadLine();



                if (answer == "Lock") userDoor.Lock();
                else if (answer == "Unlock")
                {
                    // When the user trys to unlock the door, they have to put in the password first
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("What is the passcode?");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.White;
                    int passwordGuess = Convert.ToInt32(Console.ReadLine());
                    userDoor.Unlock(passwordGuess);
                }


                else if (answer == "Open") userDoor.Open();
                else if (answer == "Close") userDoor.Close();

                else if (answer == "Change Password")
                {
                    // Ask the user for the orginal password first before they can make a new one
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("What is the passcode?");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.White;
                    int currentPassword = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    Console.WriteLine("What is the new passcode?");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.White;
                    int newPassword = Convert.ToInt32(Console.ReadLine());

                    userDoor.ChangePassword(currentPassword, newPassword);

                }
            }



        }
    }
    public class Door
    {
        // Fields
        private int doorPasscode = -1;
        private DoorActions doorAction = DoorActions.None;

        // gets and sets
        public int DoorPasscode
        {
            get { return this.doorPasscode; }
            set { this.doorPasscode = value; }
        }

        public DoorActions DoorAction
        {
            get { return this.doorAction; }
            set { this.doorAction = value; }
        }


        // Constructor
        public Door(int aDoorPasscode)
        {
            this.doorPasscode = aDoorPasscode;
            doorAction = DoorActions.Close;
        }

        // Methods
        public void Lock()
        {
            if (doorAction == DoorActions.Close) doorAction = DoorActions.Lock;
        }

        public void Unlock(int aDoorPasscode) 
        {
            if (doorAction == DoorActions.Lock && aDoorPasscode == doorPasscode) doorAction = DoorActions.Close;
        }

        public void Open()
        {
            if (doorAction == DoorActions.Close) doorAction = DoorActions.Open;
        }

        public void Close()
        {
            if (doorAction == DoorActions.Open) doorAction = DoorActions.Close;
        }

        public void ChangePassword(int password, int newPassword)
        {
            if (password == doorPasscode) doorPasscode = newPassword;
        }

    }

    public enum DoorActions {None,Open, Close, Lock};
}
