using LibraryTaxi.Enum;
using LibraryTaxi.Factory.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Factory
{
    public sealed class ConcreteFactoryCreator
    {
        Dictionary<TaxiTypes, TaxiFactory> _factories;

        public ConcreteFactoryCreator()
        {
            _factories = new Dictionary<TaxiTypes, TaxiFactory>();
            _factories[TaxiTypes.Cargo] = new CargoTaxiFactory();
            _factories[TaxiTypes.Pass] = new PassTaxiFactory();
            _factories[TaxiTypes.Ricksha] = new RickshaTaxiFactory();
        }

        public TaxiFactory GetConcreteFactory (TaxiTypes taxiTypes)
        {
            return _factories[taxiTypes];
        }
    }
}
