/*
Class: CSE 1322L
Section: XX, replace with the actual section number.
Term: Spring 2020
Instructor: Kevin Markley
Name: My Name
Assignment 4
*/

using System;

namespace Assignment4
{
    public class BaseConversion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("753 in decimal is "+ RecursiveBaseConversion(753, 8) + " in base 8.");
            Console.WriteLine("753 in decimal is " + RecursiveBaseConversion(753, 16) + " in base 16.");
            Console.WriteLine("9098 in decimal is " + RecursiveBaseConversion(9098, 20) + " in base 20.");
            Console.WriteLine("692 in decimal is " + RecursiveBaseConversion(692, 2) + " in base 2.");
            //After completing the method below, call that method here with either user input or hardcoded values as the arguments and print out the result.
            //DO NOT print or get user input in the below method.
        }

        //Complete the below method according to the instructions found on the FYE website for assignment 4.
        //You MAY NOT CHANGE the below method signature or create your own methods or functions.
        /**
            * Method that will return the value of any number converted to any other base number system, as long as the base number system is from 2 - 36.
            *
            * @param  numberToConvert   The number that will be converted to a different base number system. Must start in the decimal number system (base 10).
            * @param  numberSystemToConvertTo   The base number system to convert the base 10 number into.
            * @return             The final return will be a complete number in the other base number system (saved as a string to hold anything from 0 - 9, and A - Z).
        */
        public static String RecursiveBaseConversion(int numberToConvert, int numberSystemToConvertTo)
        {
            int highestPow = (int)(Math.Log(numberToConvert) / Math.Log(numberSystemToConvertTo));
            int highestMul = (int)(numberToConvert / Math.Pow(numberSystemToConvertTo, highestPow));

            if (highestPow > 0)
            {
                numberToConvert -= highestMul*(int)MathF.Pow(numberSystemToConvertTo, highestPow);
                string right = RecursiveBaseConversion(numberToConvert, numberSystemToConvertTo);
                while (right.Length < highestPow)
                {
                    right = "0" + right;
                }
                if (highestMul > 10)
                {
                    return (char)(highestMul + 55) + right;
                }
                return highestMul + right;
            }else
            {
                if (numberToConvert > 10)
                {
                    return ((char)(numberToConvert + 55)).ToString();
                }
                return numberToConvert.ToString();
            }
        }
    }
}
