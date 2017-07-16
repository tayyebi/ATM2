using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM2.Models;

namespace ATM2.ModelViews
{
    class Transactions : BaseModelView
    {
        public Transactions(ref MainModel DatabaseContext) : base(ref DatabaseContext)
        {
        }
        public IEnumerable<object> LastActivity()
        {
            //return databaseContext.ATMs.Select(x => new
            //{
            //    x.LocationId,
            //    x.Code
            //})
            //.ToList();

            return
                (from transaction in databaseContext.Transactions

                    // left outer join

                    join the_atm in databaseContext.ATMs
                    on transaction.AtmId equals the_atm.Code into leftATMs
                    from atm in leftATMs.DefaultIfEmpty()


                    join the_car in databaseContext.Cars
                    on transaction.CarId equals the_car.Id into leftCar
                    from car in leftCar.DefaultIfEmpty()


                 orderby transaction.Id descending

                 select new { Id = transaction.Id, Car = car.Model, ATM = atm.Code }
                )
                .Take(10)
                .ToList();
        }
    }
}
