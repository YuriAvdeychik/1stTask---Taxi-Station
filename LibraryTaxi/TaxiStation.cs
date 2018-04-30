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
        private TaxiFactory taxiFactory;
        private ConcreteFactoryCreator factoryCreator;
        private List<ITaxi> taxis;

        public TaxiStation()
        {
            factoryCreator = new ConcreteFactoryCreator();
            taxis = new List<ITaxi>();
        }

        public void CreateTaxi(TaxiTypes taxiType, int speed, int price, int cons)
        {
            taxiFactory = factoryCreator.GetConcreteFactory(taxiType);
            ITaxi taxi = taxiFactory.CreateTaxi(speed, price, cons);
            taxis.Add(taxi);
        }
    }
}
