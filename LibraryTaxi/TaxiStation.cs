using LibraryTaxi.Enum;
using LibraryTaxi.Factory;
using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi
{
    public class TaxiStation
    {
        private TaxiFactory _taxiFactory;
        private ConcreteFactoryCreator _factoryCreator;
        public List<ITaxi> _taxis;
        public List<ITaxi> _brokenTaxis;

        public TaxiStation()
        {
            _factoryCreator = new ConcreteFactoryCreator();
            _taxis = new List<ITaxi>();
            _brokenTaxis = new List<ITaxi>();
        }

        public void CreateTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int capasity = 0)
        {
            _taxiFactory = _factoryCreator.GetConcreteFactory(taxiType);
            ITaxi taxi = _taxiFactory.CreateTaxi(taxiType, speed, price, consumption, capasity);
            _taxis.Add(taxi);
        }

        public void ShowTaxis()
        {
            Console.WriteLine("Type\tSpeed\tPrice\tConsumption\tCapasity");
            foreach (var taxi in _taxis)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", taxi.TaxiType, taxi.Speed, taxi.Price, taxi.Consumption, taxi.Capacity);
            }
            Console.WriteLine();
        }

        public List<ITaxi> FindTaxiBySpeed(int minSpeed, int maxSpeed)
        {
            List<ITaxi> findedTaxis = new List<ITaxi>();

            foreach (ITaxi taxi in _taxis)
            {
                if (taxi.Speed >= minSpeed && taxi.Speed <= maxSpeed)
                {
                    findedTaxis.Add(taxi);
                }
            }
            return findedTaxis;
        }

        public ITaxi FindTaxiByConsumption(int consumption)
        {
            foreach (ITaxi taxi in _taxis)
            {
                if (taxi.Consumption == consumption)
                {
                    return taxi;
                }
            }
            return null;
        }

        public int TotalTaxisCount()
        {
            return _taxis.Sum(x => x.Price);
        }

        public List<ITaxi> SortTaxisByCons()
        {
            List<ITaxi> sortedTaxis = _taxis.OrderBy(x => x.Consumption).ToList();
            return sortedTaxis;
        }

        public void SendTaxisToWork()
        {
            if (_taxis.Count > 0) foreach (var taxi in _taxis)
            { 
                if (taxi.IsReadyToWork == true )
                {
                    Console.Write("\n{0} ",taxi.Price);
                    taxi.GoToWork();
                    Console.Write(" with {0} fuel", taxi.Consumption);
                }
                else
                {
                    Console.Write("\n{0} ", taxi.Price);
                    taxi.GoToFuelStation();
                    Console.Write(" with {0} fuel", taxi.Consumption);
                }
            }
            else
            {
                Console.WriteLine("No working taxis in Taxi Station");
            }
        }

        public void BreakTaxi(ITaxi taxi)
        {
            if (taxi != null)
            {
                _taxis.Remove(taxi);
                _brokenTaxis.Add(taxi);
            }
        }

        public void ShowBrokenTaxis()
        {
            Console.WriteLine("Type\tSpeed\tPrice\tConsumption\tCapasity");
            foreach (var taxi in _brokenTaxis)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t\t{4}", taxi.TaxiType, taxi.Speed, taxi.Price, taxi.Consumption, taxi.Capacity);
            }
            Console.WriteLine();
        }

    }
}
