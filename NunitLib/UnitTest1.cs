using ClassLibrary3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace NunitLib
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        public void PizzaName()
        {
            var pizza=new Class1 { Id = 1 , Name="Margarita",Price=1000 };
            var res=pizza.GetName();
            Assert.AreEqual("Pizza:Margarita", res);
        }

        [Test]
        public void PizzaPrice()
        {
            var pizza = new Class1 { Id = 1, Name = "Margarita", Price = 1000 };
            var res = pizza.GetPrice();
            Assert.AreEqual("Pizza:1000", res);
        }

        [Test]
        public void TestPresent()
        {
            var pizza = new Class1 { Id = 1, Name = "Pepperoni", Price = 500 };
            var res = pizza.Ispresent("Pepperoni");
            Assert.IsTrue(res);
        }

    }
}
