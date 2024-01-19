using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Nunit
{
    [TestFixture]
    public class PizzaControllerTests
    {
        [Test]
        public void PizzaSelection_ReturnsViewWithPizzas()
        {
            // Arrange
            var controller = new PizzaController();

            // Act
            var result = controller.PizzaSelection() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<Pizza>>(result.Model);
        }

        [Test]
        public void OrderCheckout_WithValidPizzaId_ReturnsViewWithOrderView()
        {
            // Arrange
            var controller = new PizzaController();
            var pizzaId = 1;
            var quantity = 2;

            // Act
            var result = controller.OrderCheckout(pizzaId, quantity) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<OrderView>(result.Model);
        }

        [Test]
        public void OrderCheckout_WithInvalidPizzaId_RedirectsToPizzaSelection()
        {
            // Arrange
            var controller = new PizzaController();
            var pizzaId = 99; // Assuming this ID is invalid

            // Act
            var result = controller.OrderCheckout(pizzaId, 1) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("PizzaSelection", result.ActionName);
        }

        [Test]
        public void OrderConfirmation_ReturnsViewWithOrderConfirmationView()
        {
            // Arrange
            var controller = new PizzaController();
            var orderView = new OrderView
            {
                SelectedPizza = new Pizza { Id = 1, Name = "Margarita", Price = 1000 },
                Quantity = 2
            };

            // Act
            var result = controller.OrderConfirmation(orderView) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<OrderConfirmationView>(result.Model);
        }

        // Add more test cases as needed for comprehensive testing
    }
}
