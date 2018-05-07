using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxi
{
    class CargoTaxi : ITaxi, IFuelable
    {
        public TaxiTypes TaxiType { get; }
        public int Speed { get; }
        public int Price { get; set; }
        public int Consumption { get; set; }
        public int Capacity { get;}
        public bool IsReadyToWork { get; set; }

        public CargoTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int capacity)
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

        public void FuelUp(int fuelVolume)
        {
            IsReadyToWork = false;
            Console.WriteLine("Cargo taxi if fueling up");
            Thread.Sleep(500);
            Consumption += fuelVolume;
            IsReadyToWork = true;
        }

        public void GoToWork()
        {
            Console.WriteLine("Cargo taxi moved on work!");
        }



    }
}
