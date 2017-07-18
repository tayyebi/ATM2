using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM2.Models;
using ATM2.Reports;

namespace ATM2.ModelViews
{
    class Transactions : BaseModelView
    {
        public Transactions(ref MainModel DatabaseContext) : base(ref DatabaseContext)
        {
        }
        public IEnumerable<object> Abstract(int ZoneId, int Year, int Month)
        {

            return
                  (

                  from transaction in databaseContext.Transactions

                  join pack in databaseContext.Packages
                  on transaction.Id equals pack.TransactionId

                  join calendar in databaseContext.CalendarDimensions
                  on transaction.DateKey equals calendar.DateKey

                  join atm in databaseContext.ATMs
                  on transaction.AtmId equals atm.Code

                  join location in databaseContext.Locations
                  on atm.LocationId equals location.Id

                  join zone in databaseContext.Zones
                  on location.ZoneId equals zone.Id


                  where zone.Id == ZoneId
                  && calendar.Month == Month
                  && calendar.Year == Year



                  select new { calendar.DateKey, Zone = zone.Name, Location = location.Name, ATM = atm.Code, TransactionAmout = pack.Count * pack.Value }


                  )
                  .OrderByDescending(x => x.DateKey)
                  .Select(x => new Report1Layout { Amount = x.TransactionAmout, Name = x.ATM })
                  .ToList();


        }
    }
}
