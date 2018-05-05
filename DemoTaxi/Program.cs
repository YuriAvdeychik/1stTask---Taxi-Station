using LibraryTaxi;
using LibraryTaxi.Enum;
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
            taxiStation.CreateTaxi(TaxiTypes.Cargo, 100, 1500, 10);
            taxiStation.CreateTaxi(TaxiTypes.Pass, 150, 1000, 5);
            taxiStation.CreateTaxi(TaxiTypes.Ricksha, 50, 500, 1);

            Console.WriteLine("\tUNSORTED TAXI STATION");
            taxiStation.ShowTaxis();

            Console.WriteLine("Total taxi station count is {0}", taxiStation.TotalTaxisCount());

            var min = 55;
            var max = 110;
            var findTaxiBySpeed = taxiStation.FindTaxiBySpeed(min, max);
            foreach (var item in findTaxiBySpeed)
            {
                Console.WriteLine("Speed between {1}-{2} is {0}",item.Speed, min, max);
            }
            
            Console.WriteLine();
            Console.WriteLine("\tSORTED TAXI STATION");
            taxiStation.SortTaxis();
            taxiStation.ShowTaxis();

            Console.ReadKey();
        }
    }
}
