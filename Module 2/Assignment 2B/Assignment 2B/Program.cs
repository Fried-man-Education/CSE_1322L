using System;
using System.Collections.Generic;

namespace Assignment_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter All-Inclusive Vacation’s budget: ");
            float budget = float.Parse(Console.ReadLine());
            Console.Write("Please enter All-Inclusive Vacation’s destination: ");
            string destination = Console.ReadLine();
            Console.Write("Please enter All-Inclusive Vacation’s brand: ");
            string brand = Console.ReadLine();
            Console.Write("Please enter All-Inclusive Vacation’s rating: ");
            int rating = int.Parse(Console.ReadLine());
            Console.Write("Please enter All-Inclusive Vacation’s price: ");
            float price = float.Parse(Console.ReadLine());
            Vacation.All_Inclusive allInclusive = new Vacation.All_Inclusive(budget, destination, brand, rating, price);
            Console.WriteLine();
            Console.WriteLine(allInclusive.ToString());
            Console.WriteLine();
            Console.WriteLine(allInclusive.sendBudget());
            Console.WriteLine();
            Console.Write("Please enter PiecemealVacation Vacation’s budget: ");
            budget = float.Parse(Console.ReadLine());
            Console.Write("Please enter PiecemealVacation’s destination: ");
            destination = Console.ReadLine();
            List<string> expenses = new List<string>();
            List<float> costs = new List<float>();
            while (true)
            {
                Console.Write("Please enter PiecemealVacation’s items: ");
                expenses.Add(Console.ReadLine());
                Console.Write("Please enter Hotel cost: ");
                costs.Add(float.Parse(Console.ReadLine()));
                Console.Write("Have you finished entering all items? ");
                if (Console.ReadLine() == "Yes")
                {
                    break;
                }
            }
            Vacation.Piecemeal piecemeal = new Vacation.Piecemeal(budget, destination, expenses.ToArray(), costs.ToArray());
            Console.WriteLine();
            Console.WriteLine(piecemeal.ToString());
            Console.WriteLine();
            Console.WriteLine(piecemeal.sendBudget());
        }
    }

    public abstract class Vacation
    {
        protected float budget;
        protected string destination;

        public override string ToString()
        {
            return this.GetType().Name + ":\n Budget: " + budget + "\n Destination: " + destination;
        }
        public string Budget(float cost)
        {
            if (budget >= cost)
            {
                return "This vacation was $" + (budget - cost) + " under budget.";
            }
            return "This vacation was $" + (cost - budget) + " over budget.";
        }

        public class All_Inclusive : Vacation
        {
            protected string brand;
            protected int rating;
            protected float price;
            public All_Inclusive (float newBudget, string newDestination, string newBrand, int newRating, float newPrice)
            {
                budget = newBudget;
                destination = newDestination;
                brand = newBrand;
                rating = newRating;
                price = newPrice;
            }
            public override string ToString()
            {
                return "The budget is $" + budget + ", the destination is " + destination + ", the brand is " + brand + ", the rating is " + rating + " stars, and the price is $" + price + ".";
            }
            public string sendBudget ()
            {
                return Budget(price);
            }
        }
        public class Piecemeal : Vacation
        {
            string[] expenses;
            float[] costs;

            public Piecemeal(float newBudget, string newDestination, string[] newExpenses, float[] newCosts)
            {
                budget = newBudget;
                destination = newDestination;
                expenses = newExpenses;
                costs = newCosts;
            }

            public override string ToString()
            {
                string temp = "The budget is $" + budget + ", the destination is " + destination + ", and the items needed for the vacation are:";
                for (int i = 0; i < expenses.Length; i++)
                {
                    if (i == expenses.Length - 1)
                    {
                        temp += " and";
                    }
                    temp += " a " + expenses[i] + " that costs $" + costs[i];
                    if (i == expenses.Length - 1)
                    {
                        temp += ".";
                    }else
                    {
                        temp += ",";
                    }
                }
                return temp;
            }

            public string sendBudget()
            {
                float sum = 0;
                foreach (float x in costs)
                {
                    sum += x;
                }
                return Budget(sum);
            }
        }
    }
}
