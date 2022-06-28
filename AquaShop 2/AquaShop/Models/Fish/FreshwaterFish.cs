using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private protected int initialSize = 3;
        //can only live in fresh waters !!!!!!!!!!
        public FreshwaterFish(string name, string species, decimal price) : base(name, species, price)
        {
            Size = initialSize;
        }

        public override void Eat()
        {
            Size += 3;
        }
    }
}
