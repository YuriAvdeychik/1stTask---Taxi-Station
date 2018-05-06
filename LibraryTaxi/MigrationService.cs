using LibraryTaxi.Enum;
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
        RickshaTaxi rickshaTaxi = new RickshaTaxi(TaxiTypes.Ricksha, 50, 500, -1);
        public void MigrationServiceWork()
        {
            rickshaTaxi.Extradition();
        }
    }
}
