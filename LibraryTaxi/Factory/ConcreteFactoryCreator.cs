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
        private Dictionary<TaxiTypes, TaxiFactory> _factories;

        public ConcreteFactoryCreator()
        {
            _factories = new Dictionary<TaxiTypes, TaxiFactory>
            {
                [TaxiTypes.Cargo] = new CargoTaxiFactory(),
                [TaxiTypes.Pass] = new PassTaxiFactory(),
                [TaxiTypes.Ricksha] = new RickshaTaxiFactory()
            };
        }

        public TaxiFactory GetConcreteFactory (TaxiTypes taxiTypes)
        {
            if (taxiTypes == TaxiTypes.Cargo | taxiTypes == TaxiTypes.Pass | taxiTypes == TaxiTypes.Ricksha)
            { 
                return _factories[taxiTypes];
            }
            else
            {
                return null;
            }
        }
    }
}
