using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operators

            int a = 8;
            int b = 2;
            Console.WriteLine(a + b);  //returns 10
            Console.WriteLine(a - b);  //returns 6
            Console.WriteLine(a * b);  //returns 16
            Console.WriteLine(a / b);  //returns 4
            Console.WriteLine(a % b);  //returns 0
            a--;
            b++;
            Console.WriteLine(a);     //returns 7
            Console.WriteLine(b);     //returns 3

            // Assignment Operator
            int m = 5;
            m += 3;
            Console.WriteLine(m);  //returns 8

            int n = 5;
            n -= 3;
            Console.WriteLine(n);  //returns 2

            int l = 5;
            l *= 3;
            Console.WriteLine(l);  //returns 15

            int o = 5;
            o /= 3;
            Console.WriteLine(o);  //returns 1

            int p = 5;
            p %= 3;
            Console.WriteLine(p);  //returns 2

            int q = 5;
            q &= 3;
            Console.WriteLine(q);  //returns 1

            int r = 5;
            r ^= 3;
            Console.WriteLine(r);  //returns  6


            // Comparison Operator
            int x = 15;
            int y = 10;

            Console.WriteLine(x == y);  // returns False because 15 is not equal to 10
            Console.WriteLine(x != y);  // returns True because 15 is not equal to 10
            Console.WriteLine(x > y);   // returns True because 15 is greater than 10
            Console.WriteLine(x < y);   // returns False because 15 is greater than 10
            Console.WriteLine(x >= y);  // returns True because 15 is greater than 10
            Console.WriteLine(x <= y);  // returns False because 15 is greater than 10

            //Logical Operator
            int z = 20;
            Console.WriteLine(z > 8 && z < 30);     // returns True because 20 is greater than 8 AND 20 is less than 30
            Console.WriteLine(z > 8 || z < 30);      // returns True because one of the conditions are True (20 is greater than 8, but 20 is not less than 30)
            Console.WriteLine(!(x > 8 && x < 30));  // returns False because ! (not) is used to reverse the result
        }
    }
}
