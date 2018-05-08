using LibraryTaxi;
using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
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
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 90, 600, 6, 15);
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 100, 500, 0, 15);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 150, 400, 5);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 160, 300, 0);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 0, 200, 0);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 10, 100, 0);

            Console.WriteLine("\tUNSORTED TAXI STATION");
            taxiStation.ShowTaxis();

            Console.WriteLine("Total taxi station count is {0}", taxiStation.TotalTaxisCount());

            int minSpeed = 90;
            int maxSpeed = 110;
            List<ITaxi> findTaxiBySpeed = taxiStation.FindTaxiBySpeed(minSpeed, maxSpeed);
            foreach (var taxi in findTaxiBySpeed)
            {
                Console.WriteLine("Taxi with speed between {2} and {3} is {0} with {1} km/h",
                    taxi.GetType().Name, taxi.Speed, minSpeed, maxSpeed);
            }

            Console.WriteLine("\n\tSORTED TAXI STATION\nType\tSpeed\tPrice\tConsumption\tCapasity");
            List<ITaxi> sortedTaxisByCons = taxiStation.SortTaxisByCons();
            foreach (var taxi in sortedTaxisByCons)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", taxi.TaxiType, taxi.Speed, taxi.Price, taxi.Consumption, taxi.Capacity);
            }

            Console.WriteLine();
            taxiStation.SendTaxisToWork();

            List<ITaxi> TaxisToBreak = taxiStation.FindTaxiBySpeed(0, 0);
            foreach (var taxi in TaxisToBreak)
            {
                taxiStation.BreakTaxi(taxi);
            }

            Console.WriteLine("\n\n\tTAXI STATION AFTER BREAKING CARS");
            taxiStation.ShowTaxis();

            Console.WriteLine("\tBROKEN TAXIS");
            taxiStation.ShowBrokenTaxis();

            FuelStation fuelStation = new FuelStation();
            foreach (var taxi in sortedTaxisByCons)
            {
                IFuelable _taxi = (IFuelable)taxiStation.FindTaxiByConsumption(0);
                fuelStation.FuelStationWork(_taxi, 10);
            }


            taxiStation.SendTaxisToWork();

            Console.ReadKey();
        }
    }
}
