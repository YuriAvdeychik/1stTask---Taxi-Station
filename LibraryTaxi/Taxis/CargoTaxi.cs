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
        public TaxiTypes TaxiType { get;}
        public int Speed { get; set; }
        public int Price { get; set; }
        public int Consumption { get; }
        public int Fuel { get; set; }
        public bool IsReadyToWork { get; set;}

        public CargoTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int fuel)
        {
            if (speed > 0)
            {
                Speed = speed;
            }
            if (price > 0)
            {
                Price = price;
            }
            if (consumption > 0)
            {
                Consumption = consumption;
            }
            if (fuel > 0)
            {
                Fuel = fuel;
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
            Console.WriteLine("{0} Cargo taxi is fueling up with {1} fuel", Price, Fuel);
            Fuel += fuelVolume;
            IsReadyToWork = true;
            Console.WriteLine("{0} Cargo taxi completed fueling with {1} fuel", Price, Fuel);
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
