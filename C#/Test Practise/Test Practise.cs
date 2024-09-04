// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

/*
The aim of this exercise is to check the presence of a number in an array.

Specifications:

    The items are integers arranged in ascending order.
    The array can contain up to 1 million items
    The array is never null

Implement the method boolean Answer.Exists(int[] ints, int k) so that it returns true if k belongs to ints, otherwise the method should return false.

Important note: Try to save CPU cycles if possible.

Example:
int[] ints = {-9, 14, 37, 102};
Answer.Exists(ints, 102) returns true
Answer.Exists(ints, 36) returns false
*/



public class Answer
{
    public static bool Exists(int[] ints, int k)
    {
        Array.Resize(ref ints, 1000000);
        //Console.WriteLine("Array resized to: {0}", ints.Length);
        Console.WriteLine("Searching for {0}", k);
        //Console.WriteLine("4th element of array: {0}", ints[3]);

        bool present = false;
        for (int i = 0; i < 1000000; i++)
        {
            if (k == ints[i])
            {
                present = true;
                break;
            }
        }
        return present;
    }
}
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { -9, 14, 37, 102 };
            Console.WriteLine("Is 102 present? {0}", Answer.Exists(ints, 102)); //true
            Console.WriteLine("Is 36 present? {0}", Answer.Exists(ints, 36)); //false
        }
    }
}