using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an app that lets you enter a bunc hof integers until the
    /// end of line with a CTRL-Z. We will say that a "clump" of these numbers
    /// is a series of 2 or more adjacent elements of the same value. The app will
    /// simply print out the number that is the count of these clumps.
    /// </summary>
    public class CountClumps
    {
        public static void Main()
        {
            // Write your codes here
            int num1 = 0;
            int clumps = 0;
            int flag = 0;
            int count = 0;
            var key = default(ConsoleKeyInfo);
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do stuff
                    Console.WriteLine("enter a number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (count == 0)
                    {
                        num1 = number;
                        if (count == 1)
                        {

                            while (num1 == number)
                            {
                                flag = 1;
                                count++;
                                if (flag == 1)
                                {
                                    clumps++;
                                }
                            }

                        }
                    }
                }
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Z || key.Modifiers != ConsoleModifiers.Control);

            Console.WriteLine(clumps);
        }
    }
}

