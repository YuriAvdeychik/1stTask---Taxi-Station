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
        IDictionary<TaxiTypes, TaxiFactory> factories;

        public ConcreteFactoryCreator()
        {
            factories = new Dictionary<TaxiTypes, TaxiFactory>();
            factories[TaxiTypes.Cargo] = new CargoTaxiFactory();
            factories[TaxiTypes.Pass] = new PassTaxiFactory();
            factories[TaxiTypes.Ricksha] = new RickshaTaxiFactory();
        }

        public TaxiFactory GetConcreteFactory (TaxiTypes taxiTypes)
        {
            return factories[taxiTypes];
        }
    }
}
