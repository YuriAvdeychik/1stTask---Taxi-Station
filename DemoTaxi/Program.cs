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
                       
            var findTaxiBySpeed = taxiStation.FindTaxiBySpeed(55, 110);
            foreach (var item in findTaxiBySpeed)
            {
                Console.WriteLine("Speed between 55-110 is {0}",item.Speed);
            }
            
            Console.WriteLine("Total taxi station count is {0}", taxiStation.TotalCount());

            Console.ReadKey();
        }
    }
}
