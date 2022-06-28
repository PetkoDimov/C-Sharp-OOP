using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal defaultPrice = 3.5M;
        private const int defaultMililiters = 50;
        public Coffee(string name, double caffeine) 
            : base(name, defaultPrice, defaultMililiters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
