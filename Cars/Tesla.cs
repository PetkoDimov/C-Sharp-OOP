﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {

        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Batteries = batteries;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Batteries { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Batteries} Batteries";
        }
    }
}
