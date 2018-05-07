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
            Console.WriteLine("Type\tSpeed\tPrice\tConsumption\tCapacity");
            var sortedTaxisByCons = taxiStation.SortTaxisByCons();
            foreach (var item in sortedTaxisByCons)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", item.TaxiType, item.Speed, item.Price, item.Consumption, item.Capacity);
            }

            Console.WriteLine();
            taxiStation.SendTaxisToWork();

            List<ITaxi> removedTaxis = taxiStation.FindTaxiBySpeed(140, 200);
            foreach (var taxi in removedTaxis)
            {
                taxiStation.RemoveTaxi(taxi);
            }

            Console.WriteLine("\n\tTAXI STATION AFTER REMOVING CARS");
            Console.WriteLine("Type\tSpeed\tPrice\tConsumption\tCapacity");
            var sortedTaxisByCons1 = taxiStation.SortTaxisByCons();
            foreach (var item in sortedTaxisByCons1)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", item.TaxiType, item.Speed, item.Price, item.Consumption, item.Capacity);
            }

            Console.WriteLine();
            MigrationService migrationService = new MigrationService();
            migrationService.MigrationServiceWork();
            AutoService autoService = new AutoService();
            autoService.AutoServiceWork();

            Console.ReadKey();
        }
    }
}
