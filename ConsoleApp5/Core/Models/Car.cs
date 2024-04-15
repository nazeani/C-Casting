﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car:Vehicle
    {
        public int PassengerCapacity {  get; set; }
        public object Marka { get; set; }

        public Car()
        {
            
        }
        public Car(int passengerCapacity)
        {
            PassengerCapacity = passengerCapacity;
        }
    }
}
