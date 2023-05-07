using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops until the user quits the program, so the stopwatch can be used repeatedly.
            while (true)
            {
                // Providing options for the user.
                Console.WriteLine("Start Stopwatch (s), Quit (q)");
                var userInput = Console.ReadLine().ToLower();

                // Creating an instance of the Stopwatch class.
                var stopWatch = new Stopwatch();

                if (userInput == "s")
                {
                    // Sets the current time as the stopwatch start time.
                    stopWatch.Start(userInput);
                    Console.WriteLine("Stop Stopwatch (x)"); // User can now stop the stopwatch.
                    userInput = Console.ReadLine();

                    if (userInput == "x" || userInput == "s")
                    {
                        // Sets current time as the stopwatch stop time.
                        stopWatch.Stop(userInput);
                        Console.WriteLine("Duration = "+ stopWatch.Duration()+"\n"); // Displays the duration.
                    }
                    else { Console.WriteLine("Invalid Input. Routing back to main menu."); } // If anything other than x is input.

                }
                else if (userInput == "q") // If the user wants to quit, the program stops.
                {
                    break;
                }
                else { Console.WriteLine("Invalid Input."); }

            }
        }
    }
}