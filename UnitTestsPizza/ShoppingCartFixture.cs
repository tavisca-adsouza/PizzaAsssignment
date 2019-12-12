using PizzaOrderingApp;
using System;
using Xunit;
using FluentAssertions;

namespace UnitTestsPizza
{
    public class ShoppingCartFixture
    {
        [Fact]
        public void Two_pizzas_can_be_added_to_a_shoppingcart()
        {
            PizzaItem margerita = new PizzaItem() { Name = "Margerita", Price = 34 };
            PizzaItem cornPizza = new PizzaItem() { Name = "CornPizza", Price = 78 };


            ShoppingCart cart = new ShoppingCart();
            cart.AddToOrderList(margerita);
            cart.AddToOrderList(cornPizza);

            cart.orderList.Contains(cornPizza).Should().Be(true);
            cart.orderList.Contains(margerita).Should().Be(true);
        }

        [Fact]

        public void At_least_two_pizzas_should_be_added_to_place_an_order()
        {
            PizzaItem margerita = new PizzaItem() { Name = "Margerita", Price = 34 };

            ShoppingCart cart = new ShoppingCart();
            cart.AddToOrderList(margerita);

            cart.CheckoutOrder().Should().BeNegative();

        }

        [Fact]

        public void If_two_pizzas_are_placed_the_an_order_will_be_made()
        {
            PizzaItem margerita = new PizzaItem() { Name = "Margerita", Price = 34 };
            PizzaItem cornPizza = new PizzaItem() { Name = "CornPizza", Price = 78 };
            ShoppingCart cart = new ShoppingCart();
            cart.AddToOrderList(margerita);
            cart.AddToOrderList(cornPizza);

            cart.CheckoutOrder().Should().BePositive();

        }
    }
}
