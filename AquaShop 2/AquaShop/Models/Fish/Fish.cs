﻿using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public abstract class Fish : IFish
    {
        private List<string> namesOfFishes = new List<string>();
        private string name;
        private string species;
        private int size;
        private decimal price;

        protected Fish(string name, string species, decimal price)
        {
            Name = name;
            Species = species;
            Price = price;
        }

        public string Name 
        { 
            get => name; 
            
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFishName);
                }
                else if(!namesOfFishes.Contains(value))
                {
                    namesOfFishes.Add(value);
                    name = value;
                }
            }
        
        }

        public string Species 
        {

            get => species;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFishSpecies);
                }
                    species = value;
                
            }

        }

        public int Size { get; protected set; }

        public decimal Price 
        {
            get => size;

            private set
            {

                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFishPrice);
                }
            }
        }

        public virtual void Eat()
        {
            Size++;
        }
    }
}
