using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderingApp
{
    public class ShoppingCart
    {
        public List<PizzaItem> orderList = new List<PizzaItem>();
        public void DisplayOrderList()
        {
          
            foreach (var pizzaItem in orderList)
            {
                Console.WriteLine(pizzaItem);
            }
        }

        public void AddToOrderList(PizzaItem pizzaItem)
        {
            
            orderList.Add(pizzaItem);
        }

        public int CheckoutOrder()
        {
            if(orderList.Count < 2)
            {
                Console.WriteLine("You have to order at least 2 pizzas.");
                return -1;
            }
            else
            {
                //do checkout of order here
                Console.WriteLine("Your order has been succesfully processed.");
                return 1;
            }
        }

    }
}
