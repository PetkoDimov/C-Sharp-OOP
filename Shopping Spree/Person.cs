﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {

            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public string Name 
        {

            get => name;
            private set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => money;

            private set
            {

                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public void AddProduct(Product product)
        {

            if (product.Cost > Money)
            {
                throw new InvalidOperationException($"{Name} can't afford {product.Name}");
            }

            products.Add(product);
            Money -= product.Cost;
        
        }

        public override string ToString()
        {
            if (products.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }

            return $"{Name} - {string.Join(", ", products.Select(p => p.Name))}";
        }
    }
}
