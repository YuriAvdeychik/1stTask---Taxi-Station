﻿using LibraryTaxi.Enum;
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
        private List<ITaxi> _taxis;
        public List<ITaxi> _Taxis;

        public TaxiStation()
        {
            _factoryCreator = new ConcreteFactoryCreator();
            _taxis = new List<ITaxi>();

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
            foreach (var taxi in _taxis)
                taxi.GoToWork();
        }

        public void BrokeTaxi(ITaxi taxi)
        {
            if (taxi != null)
            {
                _taxis.Remove(taxi);
                _Taxis = _taxis;
            }
        }

        public void BrokeTaxi(int consumption)
        {
            ITaxi taxi = _taxis.First(x => x.Consumption == consumption);
            _taxis.Remove(taxi);
        }
    }
}
