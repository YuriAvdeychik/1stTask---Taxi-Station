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
        private List<ITaxi> _taxis;

        public TaxiStation()
        {
            _factoryCreator = new ConcreteFactoryCreator();
            _taxis = new List<ITaxi>();
        }

        public void CreateTaxi(TaxiTypes taxiType, int speed, int price, int cons)
        {
            _taxiFactory = _factoryCreator.GetConcreteFactory(taxiType);
            ITaxi taxi = _taxiFactory.CreateTaxi(speed, price, cons);
            _taxis.Add(taxi);
        }

        public List<ITaxi> FindTaxiBySpeed(int minSpeed, int maxSpeed)
        {
            List<ITaxi> _findedTaxis = new List<ITaxi>();

            foreach (ITaxi taxi in _taxis)
            {
                if (taxi.Speed>=minSpeed && taxi.Speed<=maxSpeed)
                {
                    _findedTaxis.Add(taxi);
                }
            }
            return _findedTaxis;
        }
    }
}
