using ClassLibrary3;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowJoePizza.StepDefinitions
{
    [Binding]
    public class JoePizzaStepDefinitions
    {
        private string pizza;
        private string pizza1;
        private string result;
        private bool res;
        private int price;
        private readonly ScenarioContext scenarioContext;
        private readonly Class1 class1;

        public JoePizzaStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            class1 = new Class1();
        }
        [Given(@"a pizza where name is ""([^""]*)""")]
        public void GivenAPizzaWhereNameIs(string margarita)
        {
            pizza = margarita;
        }

        [When(@"PizzaName method is called")]
        public void WhenPizzaNameMethodIsCalled()
        {
            result=class1.GetName();
        }

        [Then(@"the result should be Margarita")]
        public void ThenTheResultShouldBeMargarita()
        {
            result.Should().Be(result);
        }

        [Given(@"a pizza where price is (.*)")]
        public void GivenAPizzaWherePriceIs(int p0)
        {
               price=p0;
        }

        [When(@"PizzaPrice method is called")]
        public void WhenPizzaPriceMethodIsCalled()
        {
          result= class1.GetPrice();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(result);
        }

        [Given(@"a pizza where name is ""([^""]*)"" or ""([^""]*)""")]
        public void GivenAPizzaWhereNameIsOr(string margarita, string pepperoni)
        {
            pizza = margarita;
            pizza1 = pepperoni;
        }

        [When(@"Ispresent method is called")]
        public void WhenIspresentMethodIsCalled()   
        {
            res = class1.Ispresent(pizza1);
           
        }

        [Then(@"the result should  be true")]
        public void ThenTheResultShouldBeTrue()
        {
            res.Should().Be(res);
        }
    }
}
