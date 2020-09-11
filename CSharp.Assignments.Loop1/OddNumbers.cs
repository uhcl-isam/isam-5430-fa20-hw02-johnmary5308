using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            int start;
            int end;
            Console.Error.WriteLine("Enter the starting number");
            // Codes to enter start
            start = Convert.ToInt32(Console.ReadLine());
            Console.Error.WriteLine("Enter the ending number");
            // Codes to enter end.
            end = Convert.ToInt32(Console.ReadLine());

            while(start <= end)
            {
                
                if (start % 2 == 1 || start % 2 == -1)
                {
                    Console.WriteLine(start);
                }
                start++;
            }
        }
    }
}
