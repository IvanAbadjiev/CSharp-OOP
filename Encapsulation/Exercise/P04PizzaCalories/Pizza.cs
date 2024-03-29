﻿namespace PizzaCalories
{
    public class Pizza
    {


        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;

            toppings = new();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15) throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }


        public Dough Dough { get; private set; }

        public double Calories => Dough.Calories + toppings.Sum(t => t.Calories);

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);
        }


    }
}
