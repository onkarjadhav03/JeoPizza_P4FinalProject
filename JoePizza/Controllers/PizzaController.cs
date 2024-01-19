using JoePizza.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoePizza.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult PizzaSelection()
        {
            var pizzas = new List<Pizza>
    {
        new Pizza { Id = 1, Name = "Margarita", Price = 1000 },
        new Pizza { Id = 2, Name = "Pepperoni", Price = 1000 }
    };
            return View(pizzas);
        }
        [HttpPost]
        public IActionResult OrderCheckout(int pizzaId, int quantity)
        {
            var selectedPizza = GetPizzaById(pizzaId);

            if (selectedPizza == null)
            {
                // Handle invalid pizza selection
                return RedirectToAction("PizzaSelection");
            }

            var orderView = new OrderView
            {
                SelectedPizza = selectedPizza,
                Quantity = quantity
            };
            return View(orderView);
        }
        [HttpPost]
        public IActionResult OrderConfirmation(OrderView orderView)
        {
            var orderId = new Random().Next(1000, 9999);
            var selectedPizza = GetPizzaById(orderView.SelectedPizza.Id);

            var viewModel = new OrderConfirmationView
            {
                OrderView = new OrderView
                {
                    SelectedPizza = selectedPizza,
                    Quantity = orderView.Quantity
                },
                OrderId = orderId
            };

            return View(viewModel);
        }


        public Pizza GetPizzaById(int pizzaId)
        {
            var pizzas = new List<Pizza>
{
    new Pizza { Id = 1, Name = "Margarita", Price = 1000 },
    new Pizza { Id = 2, Name = "Pepperoni", Price = 900 }
};
            return pizzas.FirstOrDefault(p => p.Id == pizzaId);
        }
    }
}
