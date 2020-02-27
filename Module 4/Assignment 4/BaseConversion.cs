/*
Class: CSE 1322L
Section: 02
Term: Spring 2020
Instructor: Kevin Markley
Name: Andrew Friedman
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
        }

        public static String RecursiveBaseConversion(int numberToConvert, int numberSystemToConvertTo)
        {
            int highestPow = (int)(Math.Log(numberToConvert) / Math.Log(numberSystemToConvertTo));
            int highestDiv = (int)Math.Pow(numberSystemToConvertTo, highestPow);

            if (highestPow > 0)
            {
                int highestMul = numberToConvert / highestDiv;
                numberToConvert -= highestMul * highestDiv;
                
                string right = RecursiveBaseConversion(numberToConvert, numberSystemToConvertTo);
                while (right.Length < highestPow) right = "0" + right;

                if (highestMul > 10) return (char)(highestMul + 55) + right;
                return highestMul + right;
            }else
            {
                if (numberToConvert > 10) return ((char)(numberToConvert + 55)).ToString();
                return numberToConvert.ToString();
            }
        }
    }
}
