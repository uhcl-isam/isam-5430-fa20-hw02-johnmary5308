
using System;
using System.ComponentModel.DataAnnotations;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter a 9 digit positive integer");
            int count = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            int r;
            int sum = 0;
            int n = num;
            while( num > 0 && count <= 9)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
                count += 1;

            }
            if (n == sum)
            {
                Console.WriteLine("a palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }



        }
    }
}
