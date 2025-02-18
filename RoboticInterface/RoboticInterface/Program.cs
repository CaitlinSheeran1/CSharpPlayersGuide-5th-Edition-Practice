﻿// Caitlin Sheeran
// 2/17/2025

using System;
using static TheOldRobot.Robot;

namespace TheOldRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("   Please select three options for the robot.");
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   on\toff\tnorth\tsouth\twest\teast");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Option {i + 1}: ");
                string choice = Console.ReadLine();

                IRobotCommand? command = null;

                if (choice == "on") command = new OnCommand();
                else if (choice == "off") command = new OffCommand();
                else if (choice == "north") command = new NorthCommand();
                else if (choice == "south") command = new SouthCommand();
                else if (choice == "west") command = new WestCommand();
                else if (choice == "east") command = new EastCommand();
                else
                {
                    Console.WriteLine("Not an option. Try again");
                    i--;
                }

                robot.Commands[i] = command;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            robot.Run();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
        }
    }
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];

        public void Run()
        {
            foreach (IRobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"                  [{X} {Y} {IsPowered}]");
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