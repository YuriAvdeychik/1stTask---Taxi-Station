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
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 100, 1500, 10, 15);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 150, 2000, 5);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 50, 500, 0);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 40, 400, 2);

            Console.WriteLine("\tUNSORTED TAXI STATION");
            taxiStation.ShowTaxis();

            Console.WriteLine("Total taxi station count is {0}", taxiStation.TotalTaxisCount());

            int minSpeed = 90;
            int maxSpeed = 110;
            var findTaxiBySpeed = taxiStation.FindTaxiBySpeed(minSpeed, maxSpeed);
            foreach (var taxi in findTaxiBySpeed)
            {
                Console.WriteLine("Taxi with speed between {2} and {3} is {0} with {1} km/h",
                    taxi.GetType().Name, taxi.Speed, minSpeed, maxSpeed);
            }

            Console.WriteLine("\n\tSORTED TAXI STATION\nType\tSpeed\tPrice\tConsumption\tCapasity");
            var sortedTaxisByCons = taxiStation.SortTaxisByCons();
            foreach (var taxi in sortedTaxisByCons)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", taxi.TaxiType, taxi.Speed, taxi.Price, taxi.Consumption, taxi.Capacity);
            }

            Console.WriteLine();
            taxiStation.SendTaxisToWork();

            List<ITaxi> brokenTaxis = taxiStation.FindTaxiBySpeed(90, 200);
            foreach (var taxi in brokenTaxis)
            {
                taxiStation.BrokeTaxi(taxi);
            }

            //List<ITaxi> brokenTaxis1 = taxiStation.SortTaxisByCons();
            //foreach (var taxi in brokenTaxis1)
            //{
            //    taxiStation.BrokeTaxi(10);
            //}

            Console.WriteLine("\n\tTAXI STATION AFTER BROKING CARS");
            taxiStation.ShowTaxis();

            Console.WriteLine("\tBROKEN TAXIS");
            taxiStation.ShowRemovedTaxis();

            FuelStation fuelStation = new FuelStation();
            IFuelable taxi1 = taxiStation.FindTaxiByConsumption(0);
            fuelStation.FuelStationWork(taxi1, 10);

            Console.WriteLine();
            taxiStation.SendTaxisToWork();

            Console.ReadKey();
        }
    }
}
