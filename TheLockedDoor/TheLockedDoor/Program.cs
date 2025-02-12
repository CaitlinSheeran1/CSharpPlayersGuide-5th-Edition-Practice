// Caitlin Sheeran
// 2/5/2025


using System.Linq.Expressions;

namespace TheLockedDoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please select a passcode for the door: ");
            int passcode = Convert.ToInt32(Console.ReadLine());
            Door userDoor = new Door(passode);

            while (true)
            {
                Console.WriteLine("Select Lock, Unlock, Open, or Close");
                string answer = Console.ReadLine();

                if (answer == "Lock") userDoor.Lock();
                else if (answer == "Unlock") userDoor.Unlock();
                else if (answer == "Open") userDoor.Open();
                else if (answer == "Close") userDoor.Close();
            }



            Console.ReadKey();
        }
    }
    public class Door
    {
        private int doorPasscode = -1;
        private DoorActions doorAction = DoorActions.None;

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


        public Door(int aDoorPasscode, DoorActions aDoorActions)
        {
            this.doorPasscode = aDoorPasscode;
            this.doorAction = aDoorActions;
        }
        public void Lock()
        {
            
        }

        public void Unlock(int aDoorPasscode) {

        }

        public void Open()
        {

        }

        public void Close()
        {

        }
    }

    public enum DoorActions {None,Open, Close, Lock};
}
