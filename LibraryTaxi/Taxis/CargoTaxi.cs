using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxis
{
    class CargoTaxi : ITaxi, IFuelable
    {
        public TaxiTypes TaxiType { get; set; }
        public int Speed { get; set; }
        public int Price { get; set; }
        public int Consumption { get; set; }
        public int Capacity { get; set; }
        public bool IsReadyToWork { get; set; }

        public CargoTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int capacity)
        {

            Speed = speed > 0 ? Speed = speed : 0;

            if (price > 0)
            {
                Price = price;
            }
            if (consumption > 0)
            {
                Consumption = consumption;
            }
            if (capacity > 0)
            {
                Capacity = capacity;
            }
            TaxiType = taxiType;
            if (consumption == 0)
            {
                IsReadyToWork = false;
            }
            else
            {
                IsReadyToWork = true;
            }
        }

        public void FuelUp(ushort fuelVolume)
        {
            IsReadyToWork = false;
            Console.WriteLine("{0} Cargo taxi is fueling up with {1} fuel", Price, Consumption);
            Consumption += fuelVolume;
            IsReadyToWork = true;
            Console.WriteLine("{0} Cargo taxi completed fueling with {1} fuel", Price, Consumption);
        }

        public void GoToWork()
        {
            Console.Write("Cargo taxi moved on work");
        }

        public void GoToFuelStation()
        {
            Console.Write("Cargo taxi moved to FuelStation");
        }


    }
}
