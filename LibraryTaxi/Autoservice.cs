using LibraryTaxi.Enum;
using LibraryTaxi.Taxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi
{
    public class AutoService
    {
        PassTaxi passTaxi = new PassTaxi(TaxiTypes.Pass, 150, -1, 5);
        CargoTaxi cargoTaxi = new CargoTaxi(TaxiTypes.Cargo, -1, 1500, 10, 15);
        public void AutoServiceWork()
        {
            cargoTaxi.Repair();
            passTaxi.Repair();
        }
    }
}
