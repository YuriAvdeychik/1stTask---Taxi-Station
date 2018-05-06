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
            taxiStation.CreateTaxi(TaxiTypes.Cargo, -1, 1500, 10, 15);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 150, -1, 5);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 50, 500, -1);

            Console.WriteLine("\tUNSORTED TAXI STATION");
            taxiStation.ShowTaxis();

            Console.WriteLine("Total taxi station count is {0}", taxiStation.TotalTaxisCount());

            var min = 10;
            var max = 110;
            var findTaxiBySpeed = taxiStation.FindTaxiBySpeed(min, max);
            foreach (var item in findTaxiBySpeed)
            {
                Console.WriteLine("Taxi with speed between {2} and {3} is {0} with {1} km/h",item.GetType().Name,item.Speed, min, max);
            }
            
            Console.WriteLine("\n\tSORTED TAXI STATION");
            Console.WriteLine("Type\t\tSpeed\tPrice\tConsumption");
            var sortedTaxisByCons = taxiStation.SortTaxisByCons();
            foreach (var item in sortedTaxisByCons)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",item.GetType().Name, item.Speed, item.Price, item.Cons);
            }

            Console.WriteLine();
            taxiStation.SendTaxisToWork();

            //CargoTaxi cargoTaxi = new CargoTaxi(140, -1, 10);
            //Console.WriteLine("{0} {1} {2}", cargoTaxi.Speed, cargoTaxi.Price, cargoTaxi.Cons);

            //List<ITaxi> removedTaxis = taxiStation.();
            //foreach (var taxi in removedTaxis)
            //{
            //    taxiStation.RemoveTaxi(10);
            //}

            Console.WriteLine("\n\tTAXI STATION AFTER REMOVING CARS");
            Console.WriteLine("Type\t\tSpeed\tPrice\tConsumption");
            var sortedTaxisByCons1 = taxiStation.SortTaxisByCons();
            foreach (var item in sortedTaxisByCons1)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.GetType().Name, item.Speed, item.Price, item.Cons);
            }

            Console.ReadKey();
        }
    }
}
