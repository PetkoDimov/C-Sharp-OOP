using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double busAirConditionModifier = 1.4;

        public Bus(double fuel, double fuelConsumption, double tankCapacity) 
            : base(fuel, fuelConsumption, tankCapacity, busAirConditionModifier)
        {
        }

        public void TurnOnAirConditioner()
        {

            AirConditionerModifier = busAirConditionModifier;
        }

        public void TurnOffAirConditioner()
        {

            AirConditionerModifier = 0;
        }
    }
}
