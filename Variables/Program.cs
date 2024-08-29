using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int myNum = 50;
            double myDoubleNum = 7.89D;
            char myLetter = 'A';
            bool myBool = true;
            string myText = "Programming";


            // int Variable
            int x = 5;
            int y = 10;
            int z = x + y;
            Console.WriteLine(z);   //returns 15


            // boolean Variable
            bool isCodingFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCodingFun);  //returns true
            Console.WriteLine(isFishTasty);  //returns false

            // string Variable
            string firstName = "Bridge ";
            string lastName = "Labz";
            string name = firstName + lastName;
            Console.WriteLine(name);   //returns Bridge Labz

        }
    }
}
