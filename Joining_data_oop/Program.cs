using System;
using System.Collections.Generic;
using System.Linq;

namespace Joining_data_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order> // create a list of customers data, per instructions
            {
                new Order ("Acme Hardware", "Mouse", 25, 3),
                new Order ("Acme Hardware", "Keyboard", 45, 2),
                new Order ("Falls Realty", "Macbook", 800, 2),
                new Order ("Julie’s Morning Diner", "iPad", 525, 1),
                new Order ("Julie’s Morning Diner", "Credit Card Reader", 45, 1)
            };

            List<Order> alphabetizedList = AlphabetizeCustomerOrdersByCustName(orders);

            DisplayDistinctCustomersOrders(alphabetizedList);
        }

        public static void DisplayDistinctCustomersOrders(List<Order> orders) // creating a method that takes in a list of Orders and returns a list of unique customer names
        {
            List<string> distinctCustomers = new List<string>(); // create a new list that will hold the list of unique customer names

            for (int i = 0; i < orders.Count; i++) // run through the list of customer orders and...
            {
                if(!distinctCustomers.Contains(orders[i].CustomerName)) // if the customer name is not already on the list called distinctCustomers...
                {
                    double total = Decimal.ToDouble(orders[i].Price) * Convert.ToDouble(orders[i].Quanity); // create a variable that gets the total of the line item
                   
                    Console.WriteLine(orders[i].CustomerName); // write their name
                    Console.WriteLine("                 Item Price Quantity Total");
                    Console.WriteLine($"               {orders[i].Item} {orders[i].Price} {orders[i].Quanity} {total}"); // write the corresponding item, price, quantity, total

                    distinctCustomers.Add(orders[i].CustomerName); // add it to the list so when we reach this customer name again, do not pass this test and get moved to the 'else' statement
                }
                else // the program reaches this point if the customer name has been added to the list, which occurs at the end of the if statment
                {
                    double total = Decimal.ToDouble(orders[i].Price) * Convert.ToDouble(orders[i].Quanity); // create a variable that gets the total of the line item
                    
                    Console.WriteLine($"               {orders[i].Item} {orders[i].Price} {orders[i].Quanity} {total}"); // write the corresponding item, price, quantity, total
                }
            }
        }

        public static List<Order> AlphabetizeCustomerOrdersByCustName(List<Order> orders)
        {
            List<Order> alphabetizedList = orders.OrderBy(orders => orders.CustomerName).ToList();

            return alphabetizedList;
        }
    }
}
