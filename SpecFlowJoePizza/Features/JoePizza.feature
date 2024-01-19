Feature: JoePizza
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowJoePizza/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
     Scenario:Retrieve Pizza Name
      Given a pizza where name is "Margarita"
     When PizzaName method is called
    Then the result should be Margarita


       Scenario:Retrieve Pizza Price
      Given a pizza where price is 1000
     When PizzaPrice method is called
    Then the result should be 1000

        Scenario:If Pizza Name is present
      Given a pizza where name is "Margarita" or "Pepperoni"
     When Ispresent method is called
    Then the result should  be true