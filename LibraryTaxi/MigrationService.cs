using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using LibraryTaxi.Taxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi
{
    public class MigrationService
    {
        public MigrationService()
        {
            TaxiStation taxis = new TaxiStation();
            List<ITaxi> taxisForExtradition = taxis._brokenTaxis;
        }

        //public void MigrationServiceWork()
        //{
        //    foreach (var taxi in taxisForExtradition)
        //    {
        //        taxi.Extradition();
        //    }
        //}
    }
}
