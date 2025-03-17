// Caitlin Sheeran
// 3/16/2025

using static ListsOfCommands.Robot;

namespace ListsOfCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("       Please select options for the robot.");
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   on\toff\tnorth\tsouth\twest\teast\tstop");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            List<IRobotCommand> commands = new List<IRobotCommand>();


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Option {commands.Count + 1}: ");
                string choice = Console.ReadLine();

                IRobotCommand? command = null;

                if (choice == "on")
                    command = new OnCommand();
                else if (choice == "off")
                    command = new OffCommand();
                else if (choice == "north")
                    command = new NorthCommand();
                else if (choice == "south")
                    command = new SouthCommand();
                else if (choice == "west")
                    command = new WestCommand();
                else if (choice == "east")
                    command = new EastCommand();
                else if (choice == "stop")
                    break;
                else
                {
                    Console.WriteLine("Not an option. Try again");
                    continue;
                }

                commands.Add(command);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            robot.Run(commands);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
        }
    }
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public List<IRobotCommand> Commands { get; set; } = new List<IRobotCommand>();
        public void Run(List<IRobotCommand> commands)
        {
            foreach (IRobotCommand? command in commands)
            {
                command?.Run(this);
                Console.WriteLine($"          [{X} {Y} {IsPowered}]");
            }
        }
        public interface IRobotCommand
        {
            void Run(Robot robot);
        }
        public class OnCommand : IRobotCommand
        {
            public void Run(Robot robot)
            {
                robot.IsPowered = true;
            }
        }
        public class OffCommand : IRobotCommand
        {
            public void Run(Robot robot)
            {
                robot.IsPowered = false;
            }
        }


        public class NorthCommand : IRobotCommand
        {
            public void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
        }
        public class SouthCommand : IRobotCommand
        {
            public void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
        }
        public class WestCommand : IRobotCommand
        {
            public void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
        }
        public class EastCommand : IRobotCommand
        {
            public void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
        }

    }
}
