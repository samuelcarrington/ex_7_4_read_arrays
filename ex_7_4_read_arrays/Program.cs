using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_4_read_arrays
{
    class Program
    {
        static void Main()
        {
            /*Write a program, which reads two arrays from the console and 
            checks whether they are equal(two arrays are equal when they are of equal length and 
            all of their elements, which have the same index, are equal). (Chapter 7, Exercise 2)
            */

            /*Two arrays are equal if they have the same value for the length and the values for their elements. 
            You can check for the second condition using a for-loop.*/


            //read the first of two arrays from the console
            Console.WriteLine("Number of elements in first array = ");
            int n1 = int.Parse(Console.ReadLine());

            //Declaring the array
            int[] a1 = new int[n1];

            //Filling the array
            for (int i = 0; i < n1; i++)
            {
                Console.Write("arr1[{0}] = ", i);
                a1[i] = int.Parse(Console.ReadLine());
            }

            //read the second of two arrays from the console
            Console.WriteLine("Number of elements in first array = ");
            int n2 = int.Parse(Console.ReadLine());

            //Declaring the array
            int[] a2 = new int[n2];

            //Filling the array
            for (int i = 0; i < n2; i++)
            {
                Console.Write("arr2[{0}] = ", i);
                a2[i] = int.Parse(Console.ReadLine());
            }

            //Two arrays are equal if they have the same value for the length and the values for their elements.
            if (a1.Length == a2.Length)
            {
                for (int i = 0; i < n2; i++)
                {
                    if (a1[i] == a2[i])
                    {
                        Console.WriteLine("The two arrays are equal?");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The two arrays are NOT equal?");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("The two arrays are NOT equal?");
                Console.ReadKey();
            }
        }
    }
}              