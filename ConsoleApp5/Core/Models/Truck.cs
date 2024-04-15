using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Truck:Vehicle
    {
        public int CarryingCapacity {  get; set; }
        public Truck()
        {
            
        }
        public Truck(int carryingCapacity)
        {
            CarryingCapacity = carryingCapacity;
        }
    }
}
