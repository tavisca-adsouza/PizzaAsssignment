using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderingApp
{
    public class Menu
    {
        List<PizzaItem> pizzaItems;
        public Menu(List<PizzaItem> pizzaItems)
        {
            this.pizzaItems = pizzaItems;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("The pizzas available are:");
            Console.WriteLine("\n");
            foreach (var pizzaItem in pizzaItems)
            {
                Console.WriteLine(pizzaItem);
            }
        }
    }
}
