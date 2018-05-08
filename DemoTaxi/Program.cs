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
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 90, 600, 0, 15);
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 100, 500, 6, 15);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 150, 400, 0);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 160, 300, 4);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 0, 200, 3);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 10, 100, 0);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 15, 50, 1);

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
                if (taxi is RickshaTaxi)
                {
                    Console.WriteLine("No taxis to fuel up");
                    break;
                }
                else
                {
                    IFuelable _taxi = (IFuelable)taxiStation.FindTaxiByConsumption(0);
                    if (_taxi != null)
                    {
                        fuelStation.FuelStationWork(_taxi, 10);
                    }
                    else
                    {
                        Console.WriteLine("No taxis to fuel up");
                        break;

                    }
                }

            }

            taxiStation.SendTaxisToWork();

            Console.ReadKey();
        }
    }
}
