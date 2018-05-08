using LibraryTaxi;
using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using LibraryTaxi.Factory;
using LibraryTaxi.Taxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiStation taxiStation = new TaxiStation();
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 90, 600, 11, 5);
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 100, 500, 16, 0);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 150, 400, 9, 0);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 160, 300, 10, 6);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 0, 200, 1);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 10, 100, 2);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 15, 50, 3);
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 110, 700, 13, 0);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 140, 800, 8, 0);

            Console.WriteLine("\tUNSORTED TAXI STATION");
            taxiStation.ShowTaxis();

            Console.WriteLine("Total taxi station count is {0}", taxiStation.TotalTaxisCount());

            int minSpeed = 90;
            int maxSpeed = 110;
            List<ITaxi> findTaxiBySpeed = taxiStation.FindTaxisBySpeed(minSpeed, maxSpeed);
            foreach (var taxi in findTaxiBySpeed)
            {
                Console.WriteLine("Taxi with speed between {2} and {3} is {0} with {1} km/h",
                    taxi.GetType().Name, taxi.Speed, minSpeed, maxSpeed);
            }

            Console.WriteLine("\n\tSORTED TAXI STATION\nType\tSpeed\tPrice\tConsumption\tFuel");
            List<ITaxi> sortedTaxisByCons = taxiStation.SortTaxisByConsumption();
            foreach (var taxi in sortedTaxisByCons)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", taxi.TaxiType, taxi.Speed, taxi.Price, taxi.Consumption, taxi.Fuel);
            }

            Console.WriteLine();
            taxiStation.SendTaxisToWork();

            List<ITaxi> TaxisToSell = taxiStation.FindTaxisBySpeed(0, 0);
            foreach (var taxi in TaxisToSell)
            {
                taxiStation.SellTaxi(taxi);
            }

            Console.WriteLine("\n\n\tTAXI STATION AFTER SELLING CARS");
            taxiStation.ShowTaxis();

            Console.WriteLine("\tSOLD TAXIS");
            List<ITaxi> sellTaxis = taxiStation.GetSoldTaxis();
            foreach (var taxi in sellTaxis)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", taxi.TaxiType, taxi.Speed, taxi.Price, taxi.Consumption, taxi.Fuel);
            }
            Console.WriteLine();

            FuelStation fuelStation = new FuelStation();

            foreach (ITaxi taxi in sortedTaxisByCons)
            {
                if (!(taxi is RickshaTaxi) && (taxi.Fuel == 0))
                {
                    IFuelable fuelableTaxi = (IFuelable)taxi;
                    fuelStation.FuelStationWork(fuelableTaxi, 10);
                }
            }

            taxiStation.SendTaxisToWork();

            Console.ReadKey();
        }
    }
}
