using System;

namespace Assignment_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects?
        }
    }

    public abstract class Vacation
    {
        float cost, budget;
        string destination;
        string KeptToBudget()
        {
            if (budget >= cost)
            {
                return "Vacation is under " + (budget - cost);
            }
            return "Vacation is over" + (cost - budget);
        }

        public class All_Inclusive : Vacation
        {
            string brand;
            int rating;
            float totalCost;
        }
        public class Piecemeal : Vacation
        {
            string[] expenses;
            float[] costs;
        }
    }
}
