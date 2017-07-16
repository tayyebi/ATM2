using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM2.Models;

namespace ATM2.ModelViews
{
    class ATMs : BaseModelView
    {
        public ATMs(ref MainModel DatabaseContext) : base(ref DatabaseContext)
        {
        }


        public IEnumerable<object> Abstarct()
        {
            return

                //(from b in

                (from a in
                (
                from the_atm in databaseContext.ATMs

                join the_transaction in databaseContext.Transactions
                on the_atm.Code equals the_transaction.AtmId

                join the_location in databaseContext.Locations
                on the_atm.LocationId equals the_location.Id

                join the_zone in databaseContext.Zones
                on the_location.ZoneId equals the_zone.Id
                // into ZZZZ from zone in ZZZZ.DefaultIfEmpty()

                join the_package in databaseContext.Packages
                on the_transaction.Id equals the_package.TransactionId

                join the_day in databaseContext.CalendarDimensions
                on the_transaction.DateKey equals the_day.DateKey

                select new
                {
                    the_atm,
                    the_package,
                    the_transaction,
                    the_location,
                    the_zone
                }
                )
                 select new
                 {
                     Date = a.the_transaction.DateKey,
                     Amount = a.the_package.Value * a.the_package.Count * (a.the_transaction.Way == "O" ? -1 : 1),
                     Transaction = a.the_transaction.Id,
                     ATM = a.the_atm.Code
                 }

                //)

                //group b by b.ATM into B
                //select new
                //{
                //   ATM =  1
                //}


                )
                //.OrderByDescending(x=>x.Date)
                .ToList();
        }

    }
}
